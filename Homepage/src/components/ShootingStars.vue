<template>
  <canvas ref="starsCanvas" class="stars-canvas"></canvas>
</template>

<script>
export default {
  name: 'ShootingStars',
  mounted() {
    this.initCanvas();
  },
  methods: {
    initCanvas() {
      const canvas = this.$refs.starsCanvas;
      const ctx = canvas.getContext('2d');

      canvas.width = window.innerWidth;
      canvas.height = window.innerHeight;

      let shootingStars = [];

      class ShootingStar {
        constructor() {
          this.reset();
        }

        reset() {
          this.x = -Math.random() * canvas.width;
          this.y = -Math.random() * canvas.height;
          this.length = Math.random() * 100 + 50;
          this.speed = 5;
          this.angle = Math.PI / 4;
          this.opacity = Math.random() * 0.5 + 0.5;
        }

        draw() {
          ctx.strokeStyle = `rgba(255, 255, 255, ${this.opacity})`;
          ctx.lineWidth = 2;
          ctx.beginPath();
          ctx.moveTo(this.x, this.y);
          ctx.lineTo(this.x - this.length * Math.cos(this.angle), this.y - this.length * Math.sin(this.angle));
          ctx.stroke();
        }

        update() {
          this.x += this.speed;
          this.y += this.speed;
          if (this.x - this.length * Math.cos(this.angle) > canvas.width || this.y - this.length * Math.sin(this.angle) > canvas.height) {
            this.reset();
          }
        }
      }

      function createShootingStars() {
        for (let i = 0; i < 5; i++) {
          shootingStars.push(new ShootingStar());
        }
      }

      function animate() {
        ctx.clearRect(0, 0, canvas.width, canvas.height);

        shootingStars.forEach((star) => {
          star.update();
          star.draw();
        });

        requestAnimationFrame(animate);
      }

      createShootingStars();
      animate();

      window.addEventListener('resize', () => {
        canvas.width = window.innerWidth;
        canvas.height = window.innerHeight;
        shootingStars = [];
        createShootingStars();
      });
    },
  },
};
</script>

<style scoped>
.stars-canvas {
  position: fixed;
  top: 0;
  left: 0;
  width: 100vw;
  height: 100vh;
  z-index: -1;
  background: radial-gradient(circle at bottom, #020111 0%, #000 100%);
}
</style>
