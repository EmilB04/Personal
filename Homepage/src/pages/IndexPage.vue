<template>
  <q-page class="column">
    <header id="top">
      <h1>Velkommen</h1>
      <nav>
        <q-btn flat label="Om" @click="scrollToSection('about')" />
        <q-btn flat label="Kunnskap" @click="scrollToSection('skills')" />
        <q-btn flat label="Kontakt" @click="scrollToSection('contact')" />
        <q-btn flat label="Sosiale profiler" @click="scrollToSection('social')" />
      </nav>
    </header>

    <main>
      <section id="about" class="full-screen about-section">
        <h2>Om meg</h2>
        <article>
          <p>
            Hei! Jeg er Emil Berglund, en bachelorstudent i Informatikk ved HIØ i Halden.
            Mitt studieløp startet høsten 2023 og jeg ferdigekamniert våren 2026.
            Jeg har spesielisert meg innen Programmering, og driver på siden med selvlæring av Vue og Quasar.
          </p>
          <p>
            Ved siden av studie jobber jeg hyppig på Elkjøp som salgsrådgiver. Jeg har generelt en stor interesse for teknologi og elektronikk.
            På fritiden liker jeg å spille videospill, se på film og serier, og være sosial.
          </p>
        </article>
        <article>
          <q-img style="width: 375px; height: 375px;">
            <img :src="EmilBerglund" style="width: 100%;">
          </q-img>
        </article>
      </section>

      <section id="skills" class="full-screen skills-section">
        <h2>Kunnskap</h2>
        <div class="skills">
          <div class="skill">
            <img src="path/to/html-icon.png" alt="HTML" />
            <p>HTML</p>
          </div>
          <div class="skill">
            <img src="path/to/css-icon.png" alt="CSS" />
            <p>CSS</p>
          </div>
          <div class="skill">
            <img src="path/to/js-icon.png" alt="JavaScript" />
            <p>JavaScript</p>
          </div>
          <div class="skill">
            <img src="path/to/vue-icon.png" alt="Vue.js" />
            <p>Vue.js</p>
          </div>
          <div class="skill">
            <img src="path/to/quasar-icon.png" alt="Quasar" />
            <p>Quasar</p>
          </div>
        </div>
      </section>

      <section id="contact" class="full-screen contact-section">
        <h2>Kontakt</h2>
        <p>Du kan kontakte meg på e-post: <a href="mailto:emil.berglund@live.no">emil.berglund@live.no</a></p>
        <p>Alternativt kontakt med på telefon: <a href="tel:+4798189601">+47 981 89 601</a></p>
      </section>

      <section id="social" class="full-screen social-section">
        <h2>Sosiale profiler</h2>
        <div class="social-profiles">
          <a href="https://www.linkedin.com/in/emil-berglund-336135251/" target="_blank">
            <img :src="LinkedInIcon" alt="Linkedin">
          </a>
          <a href="https://github.com/EmilB04" target="_blank">
            <img :src="GitHubIcon" alt="GitHub" />
          </a>
          <a href="" target="_blank">
            <img :src="InstagramIcon" alt="Instagram" />
          </a>
        </div>
      </section>

      <footer>
        <p>&copy; 2024 Emil Berglund. Alle rettigheter reservert.</p>
      </footer>

      <q-btn flat :label="scrollButtonLabel" @click="scrollToNextSection" class="scroll-btn" />
    </main>
  </q-page>
</template>

<script scoped>
import EmilBerglund from 'src/assets/images/IMG_0410.jpg';
import LinkedInIcon from 'src/assets/icons/linkdin_icon.png';
import GitHubIcon from 'src/assets/icons/github_icon.png';
import InstagramIcon from 'src/assets/icons/instagram_icon.png';
export default {
  name: 'IndexPage',
  data() {
    return {
      sections: ['about', 'skills', 'contact', 'social'],
      scrollButtonLabel: 'Til neste seksjon',
      EmilBerglund,
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
      window.scrollTo({ top: 0, behavior: 'smooth' });
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

<style scoped>
header {
  text-align: center;
  margin-bottom: 20px;
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
  font-size: 5rem;
  font-weight: 500;
}
h2 {
  font-size: 3.5rem;
  font-weight: 500;
}
p {
  font-size: 1.5rem;
}

.full-screen {
  height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  text-align: center;
  padding: 20px;
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
}

.skill {
  display: flex;
  flex-direction: column;
  align-items: center;
}

.social-profiles {
  display: flex;
  justify-content: center;
  gap: 20px;
}

.scroll-btn {
  position: fixed;
  bottom: 20px;
  right: 20px;
  background-color: black;
  color: white;
}

#social img {
  width: 50px;
}

footer {
  text-align: center;
  margin-top: 20px;
}
</style>
