<template>
  <v-card class="pa-4 mt-2" color="pink lighten-4" outlined>
    <strong>Saving Throws</strong>
    <div>STR: {{ character.SavingThrows_STR }}</div>
    <div>DEX: {{ character.SavingThrows_DEX }}</div>
    <div>CON: {{ character.SavingThrows_CON }}</div>
    <div>INT: {{ character.SavingThrows_INT }}</div>
    <div>WIS: {{ character.SavingThrows_WIS }}</div>
    <div>CHA: {{ character.SavingThrows_CHA }}</div>
  </v-card>
</template>

<script setup>
defineProps({
  character: Object
});
</script>
