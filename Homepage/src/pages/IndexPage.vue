<template>
  <q-page class="columm">
    <header id="top">
      <nav class="q-my-md">
        <q-btn flat label="Om" @click="scrollToSection('about')" />
        <q-btn flat label="Kunnskap" @click="scrollToSection('skills')" />
        <q-btn flat label="Kontakt" @click="scrollToSection('contact')" />
        <q-btn flat label="Sosiale profiler" @click="scrollToSection('social')" />
        <q-btn flat label="Tilbakemeldinger" @click="scrollToSection('comments')" />
      </nav>
    </header>
    <main>
      <section id="about" class="full-screen about-section">
        <div class="content">
          <h1 class="q-mx-none text-left">Hei, jeg er Emil Berglund. <br> En Informatikk student.</h1>
          <article>
            <p>
              Jeg går studiet, "informatikk - design og utvikling av IT-systemer" ved HIØ i Halden.
              Mitt studieløp startet høsten 2023 og jeg ferdigekamniert våren 2026.
              Jeg har spesielisert meg innen Programmering, og driver på smått med selvlæring av Vue og Quasar i
              tillegg.
            </p>
            <p>
              Ved siden av studie jobber jeg hyppig på Elkjøp som salgsrådgiver. Jeg har generelt en stor interesse
              for teknologi og elektronikk og liker å holde meg oppdatert på det nyeste.
              På fritiden liker jeg å spille videospill, se på film og serier, og være sosial.
            </p>
            <p>
              Som person er jeg veldig pliktoppfyllende, strukturert og nøyaktig. Jeg er også veldig lærevillig og
              liker å utfordre meg selv.
              Jeg ser på meg selv som en person som er lett å samarbeide med og som er flink til å kommunisere.
              Jeg er også veldig opptatt av å levere kvalitet og å være stolt av det jeg leverer.
            </p>
          </article>
        </div>
      </section>
      <section id="timeline" class="timeline-section">
        <div class="timeline-container">
          <article id="semester-1">
            <h3>Høst 2023</h3>
            <ul>
              <li>Programmering 1</li>
              <li>Webutvikling</li>
              <li>Design av digitale produkter</li>
            </ul>
          </article>
          <article id="semester-2">
            <h3>Vår 2024</h3>
            <ul>
              <li>Programmering 2</li>
              <li>Databasesystemer</li>
              <li>Innføring i datasikkerhet</li>
            </ul>
          </article>
          <article id="semester-3">
            <h3>Høst 2024</h3>
            <ul>
              <li>Innføring i operativsystemer</li>
              <li>Diskret matematikk</li>
              <li>Software Engineering og testing</li>
            </ul>
          </article>
          <article id="semester-4">
            <h3>Vår 2025</h3>
            <ul>
              <li>Rammeverk og .NET</li>
              <li>Algoritmer og datastrukturer</li>
              <li>Innføring i Generativ AI</li>
              <li>Utvikling av interaktive nettsteder</li>
            </ul>
          </article>
        </div>
        <div class="navigation-buttons">
          <button @click="prevSemester">Forrige</button>
          <button @click="nextSemester">Neste</button>
        </div>
      </section>


      <section id="skills" class="full-screen skills-section">
        <div class="content">
          <h2>Kunnskap</h2>
          <p>
            Som en Informatikk-student tilegner man seg et bredt spekter av kunnskap innenfor informasjonsteknologi.
            Jeg har derfor tilegnet meg en rekke ferdigheter og kunnskaper.
            Under vil du kunne se en oversikt.
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
        </div>
      </section>

      <section id="contact" class="full-screen contact-section">
        <div class="content">
          <h2>Kontakt</h2>
          <p>
            Ønsker du å kommme i kontakt med meg?
            Send meg gjerne en E-post eller en melding på LinkedIn.
          </p>
          <article>
            <a href="mailto:emil.berglund@live.no">
              <i class="fas fa-envelope"></i>
            </a>
            <a href="https://www.linkedin.com/in/emil-berglund-336135251/" target="_blank">
              <i class="fab fa-linkedin"></i>
            </a>
          </article>
        </div>
      </section>

      <section id="social" class="full-screen social-section">
        <div class="content">
          <h2>Sosiale profiler</h2>
          <span class="social-profiles">
            <a href="https://www.linkedin.com/in/emil-berglund-336135251/" target="_blank">
              <i class="fab fa-linkedin"></i>
            </a>
            <a href="https://github.com/EmilB04" target="_blank">
              <i class="fab fa-github"></i>
            </a>
            <a href="https://www.instagram.com/emilberglund04/" target="_blank">
              <i class="fab fa-instagram"></i>
            </a>
          </span>
        </div>
      </section>

      <section id="comments" class="full-screen comments-section">
        <div class="content">
          <h2>Tilbakemeldinger</h2>
          <p>
            Under vil du kunne se tilbakemeldinger på mitt arbeid fra tidligere arbeidsgivere og samarbeidspartnere
            jeg har hatt.
          </p>
          <section id="work-comments">
            <article>
              <h3>Moss Kirkelige Fellesråd</h3>
              <p>"Emil er en rolig og arbeidsom gutt. Han lærte oppgavene fort og jobbet
                selvstendig.
                Han lærte oppgavene raskt og jobbet godt."</p>
              <i>-Inger-Lise Klette</i>
            </article>
            <article>
              <h3>Specsavers</h3>
              <p>"Emil er pliktoppfyllende og grundig. Han er en hyggelig kar som lærer raskt og har gjennomført
                de oppgaver han har fatt på en god måte den tiden han var her."</p>
              <i>-Bjørn Podhorny</i>
            </article>
          </section>
        </div>
      </section>

      <q-btn flat :label="scrollButtonLabel" @click="scrollToNextSection" class="scroll-btn" />
    </main>
    <footer>
      <p>&copy; 2024 Emil Berglund. Alle rettigheter reservert.</p>
    </footer>

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
      sections: ['about', 'timeline', 'skills', 'contact', 'social', 'comments'],
      scrollButtonLabel: 'Til neste seksjon',
      currentSemester: 0,
      semesters: ['semester-1', 'semester-2', 'semester-3', 'semester-4'],
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
    },
    nextSemester() {
      if (this.currentSemester < this.semesters.length - 1) {
        this.currentSemester++;
      } else {
        this.currentSemester = 0; // Gå tilbake til første semester
      }
      this.scrollToSemester();
    },
    prevSemester() {
      if (this.currentSemester > 0) {
        this.currentSemester--;
      } else {
        this.currentSemester = this.semesters.length - 1; // Gå til siste semester
      }
      this.scrollToSemester();
    },
    scrollToSemester() {
      const container = document.querySelector('.timeline-container');
      const offset = -this.currentSemester * window.innerWidth;
      container.style.transform = `translateX(${offset}px)`;
    },
  },
  mounted() {
    window.addEventListener('scroll', this.ChangeButtonLabel);
    this.scrollToSemester(); // Start på første semester
  },
  beforeUnmount() {
    window.removeEventListener('scroll', this.ChangeButtonLabel);
  }
}
</script>

<style scoped lang="scss">
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

h3 {
  font-size: 2rem;
  font-weight: 500;
}

p {
  font-size: 1rem;
}

footer {
  text-align: center;
  margin-top: 20px;
}


.full-screen {
  height: 100vh;
  display: flex;
  flex-direction: column;
  justify-content: center;
  padding-inline: 50px;
}

.about-section {
  background: linear-gradient(135deg, #9afcff 0%, #fad0c4 100%);
}

.timeline-section {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  height: 100vh;
  position: relative;
  background: linear-gradient(135deg, #fad0c4 0%, #a1c4fd 100%);
  overflow: hidden;

  .timeline-container {
    display: flex;
    flex-shrink: 0;
    width: 100vw;
    height: 100vh;
    transition: transform 0.5s ease-in-out;
  }

  article {
    flex: 0 0 100%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    text-align: center;

    h3 {
      font-size: 3rem;
      margin-bottom: 1rem;
    }

    ul {
      list-style: none;
      padding: 0;

      li {
        font-size: 1.5rem;
        margin: 0.5rem 0;
      }
    }
  }

  .navigation-buttons {
    position: absolute;
    bottom: 20px;
    display: flex;
    gap: 20px;

    button {
      background-color: rgba(0, 0, 0, 0.7);
      color: white;
      border: none;
      padding: 10px 20px;
      font-size: 1.2rem;
      cursor: pointer;
      border-radius: 5px;
      transition: background-color 0.3s;

      &:hover {
        background-color: rgba(0, 0, 0, 0.9);
      }
    }
  }
}



.skills-section {
  background: linear-gradient(135deg, #67f664 0%, #fbc2eb 100%);

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
}

.contact-section {
  background: linear-gradient(135deg, #fbc2eb 0%, #a6c1ee 100%);

  article {
    text-align: center;
    display: flex;
    justify-content: space-around;

    a {
      color: black;
      font-size: 3rem;
    }
  }
}

.social-section {
  background: linear-gradient(135deg, #fbfda1 0%, #c2e9fb 100%);

  .social-profiles {
    display: flex;
    justify-content: space-around;
    gap: 20px;

    a {
      color: black;
      font-size: 3rem;
    }
  }
}


.comments-section {
  background: linear-gradient(135deg, #ffaeae 0%, #a6c1ee 100%);
}

.content {
  max-width: 1200px;
  margin: 0 auto;
}

.scroll-btn {
  position: fixed;
  bottom: 20px;
  right: 20px;
  background-color: black;
  color: white;
}

@media screen and (max-width: 600px) {
  h1 {
    font-size: 2rem;
  }

  h2 {
    font-size: 2rem;
  }

  h3 {
    font-size: 1.5rem;
  }

  p {
    font-size: 0.8rem;
  }

  nav {
    gap: 0px;
    padding: 0;
    flex-direction: column;
  }

  .skills {
    font-size: 1rem;
  }

  .social-profiles a {
    font-size: 2rem;
  }

}
</style>
