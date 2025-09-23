<template>
  <v-card class="pa-4 mt-2" color="pink lighten-1" outlined>
    <strong>Proficiencies & Training</strong>
    <div>Weapons: {{ proficiencies.weapons.join(', ') }}</div>
    <div>Tools: {{ proficiencies.tools.join(', ') }}</div>
    <div>Languages: {{ proficiencies.languages.join(', ') }}</div>
  </v-card>
</template>

<script setup>
defineProps({
  proficiencies: Object
});
</script>
