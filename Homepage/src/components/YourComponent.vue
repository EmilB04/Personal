<template>
  <div>
    <!-- Other template code -->
    <button @click="scrollToNextSection">
      <font-awesome-icon :icon="isScrollButtonUp ? 'arrow-up' : 'arrow-down'" />
    </button>
    <!-- Other template code -->
  </div>
</template>

<script>
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';

export default {
  components: {
    FontAwesomeIcon,
  },
  // Other script code
};
</script>
