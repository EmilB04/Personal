<template>
  <div class="fullscreen error-page text-white text-center q-pa-md flex flex-center">
    <div>
      <div class="error-code">
        404
      </div>

      <div class="error-message text-h2">
        Oops. Nothing here...
      </div>

      <q-btn class="q-mt-xl" color="white" text-color="black" unelevated to="/" label="Go Home" no-caps />
      <ShootingStars />
    </div>
  </div>
</template>

<script setup lang="ts">
import ShootingStars from 'src/components/ShootingStars.vue';
defineOptions({
  name: 'ErrorNotFound'
});
</script>

<style scoped lang="scss">
.error-page {
  background: linear-gradient(135deg, #f1376e 0%, #010a4e 70%);
}

.error-code {
  font-size: 30vh;
}

.error-message {
  opacity: 0.4;
}
</style>
