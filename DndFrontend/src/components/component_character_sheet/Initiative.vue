<template>
  <v-card class="pa-4 mb-2" outlined>
    <div class="text-h6">Initiative</div>
    <div>{{ initiative }}</div>
  </v-card>
</template>

<script setup>
defineProps({
  initiative: Number
});
</script>
