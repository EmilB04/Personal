// index.ts – Bun backend som kobler frontend til .NET backend

import { serve } from 'bun'
import { readdir, readFile } from 'fs/promises'
import { spawn } from 'child_process'
import path from 'path'

const SNAPSHOT_DIR = path.resolve('../backend/snapshots')

serve({
  port: 3000,
  async fetch(req) {
    const url = new URL(req.url)

    // Start crawling via .NET backend
    if (url.pathname === '/api/crawl' && req.method === 'POST') {
      try {
        const body = await req.json()
        const targetUrl = body.url

        if (!targetUrl || typeof targetUrl !== 'string') {
          return new Response(JSON.stringify({ success: false, message: 'Ugyldig URL' }), {
            status: 400,
            headers: { 'Content-Type': 'application/json' },
          })
        }

        // Kjør .NET crawler som CLI
        const proc = spawn('dotnet', [
          'run',
          '--project',
          '../backend/PageProbe.csproj',
          '--',
          targetUrl,
        ])
        proc.stdout.on('data', (data) => console.log('[crawler]', data.toString()))
        proc.stderr.on('data', (data) => console.error('[crawler-err]', data.toString()))

        return Response.json({ success: true })
      } catch (err) {
        return Response.json({ success: false, message: 'Feil under crawling' })
      }
    }

    // Returner snapshots for gitt URL
    if (url.pathname === '/api/snapshots') {
      const targetUrl = url.searchParams.get('url')
      const safeName = targetUrl?.replace(/[^a-z0-9]/gi, '_')

      try {
        const files = await readdir(SNAPSHOT_DIR)
        const matches = files.filter((f) => f.startsWith(safeName ?? ''))

        const snapshots = await Promise.all(
          matches.map(async (file) => {
            const raw = await readFile(path.join(SNAPSHOT_DIR, file), 'utf8')
            return JSON.parse(raw)
          }),
        )

        return Response.json({ snapshots })
      } catch {
        return Response.json({ snapshots: [] })
      }
    }

    return new Response('Not found', { status: 404 })
  },
})
