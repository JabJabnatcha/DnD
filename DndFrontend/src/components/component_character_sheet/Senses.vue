<template>
  <v-card class="pa-4 mt-2" color="pink lighten-2" outlined>
    <strong>Senses</strong>
    <div>Darkvision: {{ senses.darkvision }}</div>
    <div>Passive Perception: {{ senses.passivePerception }}</div>
  </v-card>
</template>

<script setup>
defineProps({
  senses: Object
});
</script>
