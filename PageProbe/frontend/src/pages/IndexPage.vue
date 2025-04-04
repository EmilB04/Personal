<template>
  <q-page padding class="q-gutter-md">
    <div class="text-h5">PageProbe++ Web UI</div>

    <q-input v-model="url" label="Nettadresse (URL)" filled />
    <q-btn label="Start overvåking" color="primary" @click="startCrawling" :disable="loading || !url" />

    <q-separator />

    <div v-if="snapshots.length">
      <div class="text-subtitle1">Endringer for: {{ url }}</div>
      <q-list bordered class="bg-grey-1">
        <q-item v-for="(snap, index) in snapshots" :key="index" clickable>
          <q-item-section>
            <q-item-label><strong>{{ snap.timestamp }}</strong></q-item-label>
            <q-item-label caption>{{ snap.url }}</q-item-label>
          </q-item-section>
          <q-item-section side>
            <q-btn flat icon="visibility" @click="viewSnapshot(snap)" />
          </q-item-section>
        </q-item>
      </q-list>
    </div>

    <q-dialog v-model="dialog">
      <q-card style="min-width: 60vw; max-height: 80vh; overflow: auto">
        <q-card-section>
          <div class="text-h6">Snapshot: {{ selectedSnapshot.timestamp }}</div>
        </q-card-section>
        <q-card-section>
          <pre class="text-body2">{{ selectedSnapshot.content }}</pre>
        </q-card-section>
        <q-card-actions align="right">
          <q-btn flat label="Lukk" v-close-popup />
        </q-card-actions>
      </q-card>
    </q-dialog>

    <q-spinner v-if="loading" size="xl" color="primary" />
  </q-page>
</template>

<script setup>
import { ref } from 'vue'
import { useQuasar } from 'quasar'

const url = ref('')
const snapshots = ref([])
const loading = ref(false)
const dialog = ref(false)
const selectedSnapshot = ref({})
const $q = useQuasar()

async function startCrawling() {
  loading.value = true
  try {
    const res = await fetch('/api/crawl', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
      },
      body: JSON.stringify({ url: url.value }),
    })

    const data = await res.json()
    if (data.success) {
      $q.notify({ type: 'positive', message: 'Overvåking startet!' })
      await loadSnapshots()
    } else {
      $q.notify({ type: 'negative', message: data.message || 'Feil under crawling' })
    }
  } catch {
    $q.notify({ type: 'negative', message: 'Kunne ikke starte overvåkning' })
  } finally {
    loading.value = false
  }
}

async function loadSnapshots() {
  try {
    const res = await fetch(`/api/snapshots?url=${encodeURIComponent(url.value)}`)
    const data = await res.json()
    snapshots.value = data.snapshots
  } catch {
    $q.notify({ type: 'negative', message: 'Kunne ikke laste snapshots' })
  }
}

function viewSnapshot(snap) {
  selectedSnapshot.value = snap
  dialog.value = true
}
</script>

<style scoped>
pre {
  white-space: pre-wrap;
  word-wrap: break-word;
  background-color: #f4f4f4;
  padding: 1rem;
  border-radius: 0.5rem;
}
</style>
