<template>
  <q-page class="columm">
    <header id="top">
      <nav class="q-my-md">
        <q-btn flat label="Om" @click="scrollToSection('about')" />
        <q-btn flat label="Kunnskap" @click="scrollToSection('skills')" />
        <q-btn flat label="Kontakt" @click="scrollToSection('contact')" />
        <q-btn flat label="Sosiale profiler" @click="scrollToSection('social')" />
        <q-btn flat label="Kommentarer på mitt arbeid" @click="scrollToSection('comments')" />
      </nav>
    </header>

    <main>
      <section id="about" class="full-screen about-section">
        <h1 class="q-mx-none text-left">Hei, jeg er Emil Berglund. <br> En Informatikk student.</h1>
        <article>
          <p>
            Jeg går studiet, "informatikk - design og utvikling av IT-systemer" ved HIØ i Halden.
            Mitt studieløp startet høsten 2023 og jeg ferdigekamniert våren 2026.
            Jeg har spesielisert meg innen Programmering, og driver på smått med selvlæring av Vue og Quasar i tillegg.
          </p>
          <p>
            Ved siden av studie jobber jeg hyppig på Elkjøp som salgsrådgiver. Jeg har generelt en stor interesse for
            teknologi og elektronikk og liker å holde meg oppdatert på det nyeste.
            På fritiden liker jeg å spille videospill, se på film og serier, og være sosial.
          </p>
          <p>
            Som person er jeg veldig pliktoppfyllende, strukturert og nøyaktig. Jeg er også veldig lærevillig og liker å
            utfordre meg selv.
            Jeg ser på meg selv som en person som er lett å samarbeide med og som er flink til å kommunisere.
            Jeg er også veldig opptatt av å levere kvalitet og å være stolt av det jeg leverer.
          </p>
        </article>
        <article>

        </article>
      </section>

      <section id="skills" class="full-screen skills-section">
        <h2>Kunnskap</h2>
        <p>
          Som informatikk student får man en breddelære innenfor informasjonsteknologi.
          Under vil du kunne se en oversikt over mine ferdigheter og kunnskaper.
        </p>
        <section class="skills">
          <div class="skill">
            <i class="fab fa-html5"></i>
            <p>HTML</p>
          </div>
          <div class="skill">
            <i class="fab fa-css3-alt"></i>
            <p>CSS</p>
          </div>
          <div class="skill">
            <i class="fab fa-sass"></i>
            <p>SASS</p>
          </div>
          <div class="skill">
            <i class="fab fa-python"></i>
            <p>Python</p>
          </div>
          <div class="skill">
            <i class="fab fa-java"></i>
            <p>Java</p>
          </div>
          <div class="skill">
            <i class="fas fa-database"></i>
            <p>MYSQL</p>
          </div>
          <div class="skill">
            <i class="fab fa-figma"></i>
            <p>Figma</p>
          </div>
          <div class="skill">
            <i class="fas fa-terminal"></i>
            <p>C/Shell</p>
          </div>
        </section>
      </section>

      <section id="contact" class="full-screen contact-section">
        <h2>Kontakt</h2>
        <p>
          Ønsker du å kommme i kontakt med meg?
          Send meg gjerne en E-post eller en melding på LinkedIn.
        </p>
        <div>
          <a href="">
            <i class="fas fa-envelope"></i>
          </a>
          <a href="">
            <i class="fab fa-linkedin"></i>
          </a>
        </div>
      </section>

      <section id="social" class="full-screen social-section">
        <h2>Sosiale profiler</h2>
        <div class="social-profiles">
          <a href="https://www.linkedin.com/in/emil-berglund-336135251/" target="_blank">
            <i class="fab fa-linkedin"></i>
          </a>
          <a href="https://github.com/EmilB04" target="_blank">
            <i class="fab fa-github"></i>
          </a>
          <a href="https://www.instagram.com/emilberglund04/" target="_blank">
            <i class="fab fa-instagram"></i>
          </a>
        </div>
      </section>

      <section id="comments" class="full-screen">
        <h2>Kommentarer på mitt arbeid fra tidligere arbeidsgivere</h2>
        <p>
          Her vil det komme kommentarer på mitt arbeid.
        </p>
        <section id="work-comments">
          <article>
            <h3>Moss KF</h3>
            <p>Utdtypende tekst:</p>
          </article>
          <article>
            <h3>Specsavers</h3>
            <p>Utdypende tekst:</p>
          </article>
        </section>
      </section>
      <footer>
        <p>&copy; 2024 Emil Berglund. Alle rettigheter reservert.</p>
      </footer>

      <q-btn flat :label="scrollButtonLabel" @click="scrollToNextSection" class="scroll-btn" />
    </main>
  </q-page>
</template>

<script scoped>
import LinkedInIcon from 'src/assets/icons/linkdin_icon.png';
import GitHubIcon from 'src/assets/icons/github_icon.png';
import InstagramIcon from 'src/assets/icons/instagram_icon.png';
import '@fortawesome/fontawesome-free/css/all.css';
import '@fortawesome/fontawesome-free/js/all.js';
export default {
  name: 'IndexPage',
  data() {
    return {
      sections: ['about', 'skills', 'contact', 'social', 'comments'],
      scrollButtonLabel: 'Til neste seksjon',
      LinkedInIcon,
      GitHubIcon,
      InstagramIcon
    };
  },
  methods: {
    scrollToSection(sectionId) {
      const section = document.getElementById(sectionId);
      if (section) {
        section.scrollIntoView({ behavior: 'smooth' });
      }
    },
    scrollToNextSection() {
      const currentScrollPos = window.scrollY;
      const viewportHeight = window.innerHeight;
      for (let i = 0; i < this.sections.length; i++) {
        const section = document.getElementById(this.sections[i]);
        if (section.offsetTop > currentScrollPos + viewportHeight / 2) {
          section.scrollIntoView({ behavior: 'smooth' });
          this.ChangeButtonLabel();
          return;
        }
      }

      // If at the bottom, scroll to the top
      document.getElementById('about').scrollIntoView({ behavior: 'smooth' });
      this.ChangeButtonLabel();
    },
    ChangeButtonLabel() {
      const currentScrollPos = window.scrollY;
      const viewportHeight = window.innerHeight;
      const documentHeight = document.documentElement.scrollHeight;
      const isAtBottom = currentScrollPos + viewportHeight >= documentHeight;

      if (isAtBottom || currentScrollPos + viewportHeight >= documentHeight * 0.9) {
        this.scrollButtonLabel = 'Til toppen';
      } else {
        this.scrollButtonLabel = 'Til neste seksjon';
      }
    }
  },
  mounted() {
    window.addEventListener('scroll', this.ChangeButtonLabel);
  },
  beforeUnmount() {
    window.removeEventListener('scroll', this.ChangeButtonLabel);
  }
}
</script>

<style scoped lang="scss">
header {
  text-align: center;
}

nav {
  display: flex;
  justify-content: center;
  gap: 10px;
}

main {
  display: flex;
  flex-direction: column;
}

h1 {
  font-size: 3rem;
  font-weight: 500;
  line-height: 1.4;
}

h2 {
  font-size: 3rem;
  font-weight: 500;
}

p {
  font-size: 1rem;
}

.full-screen {
  height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: center;
  padding-inline: 50px;
}

.about-section {
  background: linear-gradient(135deg, #ff9a9e 0%, #fad0c4 100%);
}

.skills-section {
  background: linear-gradient(135deg, #a18cd1 0%, #fbc2eb 100%);
}

.contact-section {
  background: linear-gradient(135deg, #fbc2eb 0%, #a6c1ee 100%);
}

.social-section {
  background: linear-gradient(135deg, #a1c4fd 0%, #c2e9fb 100%);
}

.skills {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  gap: 20px;
  font-size: 1.5rem;
}

.skill {
  display: flex;
  flex-direction: column;
  align-items: center;
}

.social-profiles {
  display: flex;
  justify-content: space-around;
  gap: 20px;
}

.social-profiles a {
  font-size: 3rem;
  color: black;
}

.scroll-btn {
  position: fixed;
  bottom: 20px;
  right: 20px;
  background-color: black;
  color: white;
}

footer {
  text-align: center;
  margin-top: 20px;
}
</style>
