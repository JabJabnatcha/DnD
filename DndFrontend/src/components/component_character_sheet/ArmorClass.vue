<template>
  <v-card class="pa-4 mb-2" outlined>
    <div class="text-h6">Armor Class</div>
    <div>{{ ac }}</div>
  </v-card>
</template>

<script setup>
defineProps({
  ac: Number
});
</script>
