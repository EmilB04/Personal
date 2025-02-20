<template>
  <q-page class="columm">
    <div id="bg-app">
      <header id="top">
        <nav class="q-my-md flex justify-between">
          <div class="justify-start">
            <q-btn flat label="Om" @click="scrollToSection('about')" />
            <q-btn flat label="Studie" @click="scrollToSection('timeline')" />
            <q-btn flat label="Kunnskap" @click="scrollToSection('skills')" />
            <q-btn flat label="GitHub" @click="scrollToSection('gitHub')" />
            <!--<q-btn flat label="Sosiale profiler" @click="scrollToSection('social')" /> -->
            <q-btn flat label="Tilbakemeldinger" @click="scrollToSection('comments')" />
          </div>
          <div class="justify-end" id="name-tag">
            <q-btn flat label="Emil Berglund" />
          </div>
        </nav>
      </header>
      <hr id="nav-seperator" />
      <main class="flex column">

        <section id="about" class="full-screen about-section">
          <div class="content">
            <h1 class="q-mx-none text-left">
              Hei, jeg er Emil Berglund. <br />
              En Informatikk student.
            </h1>
            <article>
              <p>
                Jeg går studiet, "informatikk - design og utvikling av
                IT-systemer" ved HiØ i Halden. Mitt studieløp startet høsten
                2023 og jeg ferdigekamniert våren 2026. Jeg har spesielisert meg
                innen Programmering, og driver på smått med selvlæring av Vue og
                Quasar på fritiden.
              </p>
              <p>
                Ved siden av studie jobber jeg hyppig på Elkjøp som
                salgsrådgiver. Jeg har generelt en stor interesse for teknologi
                og elektronikk og liker å holde meg oppdatert på det nyeste. På
                fritiden liker jeg å spille videospill, se på film og serier, og
                være sosial, enten dette er digitalt eller fysisk.
              </p>
              <p>
                Som person er jeg veldig pliktoppfyllende, strukturert og
                nøyaktig. Jeg er også veldig lærevillig og liker å utfordre meg
                selv. Jeg ser på meg selv som en person som er lett å samarbeide
                med og som er flink til å kommunisere. Jeg er også veldig
                opptatt av å levere kvalitet og å være stolt av det jeg leverer.
              </p>
            </article>
          </div>
        </section>

        <section id="timeline" class="timeline-section">
          <div class="timeline-container">
            <article v-for="(semester, index) in CourseList" :key="index" :id="semester.id">
              <h3>{{ semester.semester }}</h3>
              <div class="timeline-line"></div>
              <ul>
                <li v-for="(course, index) in semester.courses" :key="index" :class="{
                  'course top': index % 2 === 0,
                  'course bottom': index % 2 !== 0,
                }">
                  <a :href="course.link" class="course-link" target="_blank">
                    {{ course.name }}
                  </a>
                </li>
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
              Som en Informatikk-student tilegner man seg et bredt spekter av
              kunnskap innenfor informasjonsteknologi. Under vil du kunne se en
              oversikt.
            </p>
            <section class="skills-container">
              <h3>Rammeverk:</h3>
              <section class="skills">
                <div class="skill">
                  <i class="fab fa-vuejs"></i>
                  <p>Vue</p>
                </div>
                <div class="skill">
                  <i class="fab fa-react"></i>
                  <p>React</p>
                </div>
                <div class="skill">
                  <i class="fab fa-node-js"></i>
                  <p>Node.js</p>
                </div>
                <div class="skill">
                  <i class="fab fa-quasar"></i>
                  <p>Quasar</p>
                </div>
                <div class="skill">
                  <i class="fab fa-microsoft"></i>
                  <p>.NET & C#</p>
                </div>
              </section>

              <h3>Front-End:</h3>
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
                  <i class="fab fa-js"></i>
                  <p>JavaScript</p>
                </div>
                <div class="skill">
                  <i class="fab fa-sass"></i>
                  <p>SASS</p>
                </div>
                <div class="skill">
                  <i class="fab fa-figma"></i>
                  <p>Figma</p>
                </div>
              </section>

              <h3>Back-End:</h3>
              <section class="skills">
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
                  <i class="fas fa-terminal"></i>
                  <p>C/Shell</p>
                </div>
                <div class="skill">
                  <i class="fab fa-git-alt"></i>
                  <p>Git</p>
                </div>
                <div class="skill">
                  <i class="fab fa-github"></i>
                  <p>GitHub</p>
                </div>
              </section>
            </section>
          </div>
        </section>

        <section id="gitHub" class="full-screen github-section">
          <div class="content">
            <h2>Mine GitHub Repositories</h2>
            <div v-if="repositories.length">
              <div v-for="repo in repositories" :key="repo.id" class="repo-card">
                <h3>{{ repo.name }}</h3>
                <p>{{ repo.description }}</p>
                <a :href="repo.html_url" target="_blank">Se Repository</a>
              </div>
            </div>
            <div v-else>
              <p>Laster repositories...</p>
            </div>
            <q-btn id="goToGithub" unelevated :href="githubProfileUrl" label="Gå til GitHub profil" no-caps />
          </div>
        </section>

        <section id="comments" class="full-screen comments-section">
          <div class="content">
            <h2>Tilbakemeldinger</h2>
            <p>
              Vil du få et inntrykk av meg som person?
              Under vil du kunne se tilbakemeldinger på mitt arbeid fra
              tidligere arbeidsgivere og samarbeidspartnere jeg har hatt.
            </p>
            <section id="work-comments">
              <div v-if="WorkComments.length > 0" :key="currentIndex" class="comment">
                <p>{{ WorkComments[currentIndex].comment }}</p>
                <i class="author">-{{ WorkComments[currentIndex].author }}</i>
              </div>
            </section>
          </div>
        </section>

        <q-btn flat :icon="isAtBottom ? 'arrow_upward' : 'arrow_downward'" @click="scrollToNextSection"
          class="scroll-btn" />
      </main>
      <footer class="text-center q-ma-sm">
        <p>&copy; 2025 Emil Berglund. Alle rettigheter reservert.</p>
      </footer>
    </div>
  </q-page>
</template>

<script scoped>
import IndexScript from 'src/scripts/IndexScript.js';
import axios from 'axios';

export default {
  name: 'IndexPage',
  mixins: [IndexScript],
  data() {
    return {
      repositories: [],
      githubProfileUrl: 'https://github.com/EmilB04',
    };
  },
  mounted() {
    window.addEventListener('scroll', this.ChangeButtonLabel);
    this.scrollToSemester();
    this.startCommentRotation();
    this.ChangeButtonLabel();
    this.fetchRepositories();
  },
  beforeUnmount() {
    window.removeEventListener('scroll', this.ChangeButtonLabel);
    clearInterval(this.commentInterval);
  },
  methods: {
    async fetchRepositories() {
      try {
        const response = await axios.get('https://api.github.com/users/EmilB04/repos');
        this.repositories = response.data
          .filter(repo => repo.stargazers_count > 0)
      } catch (error) {
        console.error('Error fetching repositories:', error);
      }
    },
    nextSlide() {
      const totalSlides = this.repositories.length;
      this.currentSlide = (this.currentSlide + 1) % totalSlides;
      this.updateCarousel();
    },
    prevSlide() {
      const totalSlides = this.repositories.length;
      this.currentSlide = (this.currentSlide - 1 + totalSlides) % totalSlides;
      this.updateCarousel();
    },
    updateCarousel() {
      const carousel = this.$refs.carousel;
      const slideWidth = carousel.clientWidth;
      carousel.scrollLeft = this.currentSlide * slideWidth;
    },
  },
};
</script>

<style scoped lang="scss">
@import 'src/css/IndexStyle.scss';
</style>
