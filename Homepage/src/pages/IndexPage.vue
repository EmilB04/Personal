<template>
  <q-page class="row items-center justify-evenly">
    <header>
      <h1>Velkommen til min hjemmeside</h1>
      <nav>
        <q-btn flat label="Hjem" />
        <q-btn flat label="Om" />
        <q-btn flat label="Prosjekter" />
        <q-btn flat label="Kontakt" />
      </nav>
    </header>

    <main>
      <section>
        <h2>Om mg</h2>
        <p>
          Hei! Jeg er Emil Berglund, en bachelorstudent i Informatikk ved HIØ i Halden.
          Jeg har spesielisert meg innen Programmering, og driver på siden med selvlæring av Vue og Quasar.
        </p>
      </section>

      <section>
        <h2>Projects</h2>
        <div class="projects">
          <div class="project">
            <h3>Project 1</h3>
            <p>Brief description of Project 1.</p>
          </div>
          <div class="project">
            <h3>Project 2</h3>
            <p>Brief description of Project 2.</p>
          </div>
        </div>
      </section>

      <footer>
        <p>&copy; 2023 [Your Name]. All rights reserved.</p>
      </footer>
    </main>
  </q-page>
</template>

<script>
export default {
  name: 'IndexPage',
}
</script>

<style scoped>
main {
  display: flex;
  flex-direction: column;
}

</style>
