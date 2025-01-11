<template>
  <q-page class="columm">
    <header id="top">
      <nav class="q-my-md">
        <q-btn flat label="Om" @click="scrollToSection('about')" />
        <q-btn flat label="Studie" @click="scrollToSection('timeline')" />
        <q-btn flat label="Kunnskap" @click="scrollToSection('skills')" />
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
            <div class="timeline-line"></div>
            <ul>
              <a href="https://www.hiof.no/studier/emner/iio/itk/2023/host/itf10219.html"><li class="course top">Programmering 1</li></a>
              <a href="https://www.hiof.no/studier/emner/iio/itk/2023/host/itf10511.html"><li class="course bottom">Webutvikling</li></a>
              <a href="https://www.hiof.no/studier/emner/iio/itk/2023/host/itf14022.html"><li class="course top">Innføring i design av digitale produkter</li></a>
            </ul>
          </article>
          <article id="semester-2">
            <h3>Vår 2024</h3>
            <div class="timeline-line"></div>
            <ul>
              <li class="course bottom">Programmering 2</li>
              <li class="course top">Databasesystemer</li>
              <li class="course bottom">Innføring i datasikkerhet</li>
            </ul>
          </article>
          <article id="semester-3">
            <h3>Høst 2024</h3>
            <div class="timeline-line"></div>
            <ul>
              <li class="course top">Innføring i operativsystemer</li>
              <li class="course bottom">Diskret matematikk</li>
              <li class="course top">Software Engineering og testing</li>
            </ul>
          </article>
          <article id="semester-4">
            <h3>Vår 2025</h3>
            <div class="timeline-line"></div>
            <ul>
              <li class="course top">Rammeverk og .NET</li>
              <li class="course bottom">Algoritmer og datastrukturer</li>
              <li class="course top">Innføring i Generativ AI</li>
              <li class="course bottom">Utvikling av interaktive nettsteder</li>
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
            <div class="skill">
              <i class="fab fa-vuejs"></i>
              <p>Vue</p>
            </div>
            <div class="skill">
              <i class="fab fa-quasar"></i>
              <p>Quasar</p>
            </div>
            <div class="skill">
              <i class="fab fa-git-alt"></i>
              <p>Git</p>
            </div>

          </section>
        </div>
      </section>

      <section id="social" class="full-screen social-section">
        <div class="content">
          <h2>Sosiale profiler</h2>
          <p>Ønsker du å komme i kontakt med meg, eller ta en sniktitt på hva jeg holder på med..</p>
          <span class="social-profiles">
            <a href="https://www.linkedin.com/in/emil-berglund-336135251/" target="_blank">
              <i class="fab fa-linkedin"></i>
            </a>
            <a href="https://github.com/EmilB04" target="_blank">
              <i class="fab fa-github"></i>
            </a>
            <a href="mailto:emil.berglund@live.no">
              <i class="fas fa-envelope"></i>
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
      <p>&copy; 2025 Emil Berglund. Alle rettigheter reservert.</p>
    </footer>


    <!--TODO!-->
    <!--
    Lag dropdown menyer for hvert kurs i timelinen for desktop , evntuelt mobil også
    Menyen skal inneholde informasjon om kurset, eksamen, pensum, læringsmål, og evt. annen relevant informasjon
    Lages i JS eller TS og skal være dynamisk og kunne brukes for alle kursene
    Informasjonen skal derfor ligge i Script delen av dokumentet
    -->
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
      sections: ['about', 'timeline', 'skills', 'social', 'comments'],
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

<style scoped lang="css">
@import 'src/css/IndexStyle.css';
</style>
