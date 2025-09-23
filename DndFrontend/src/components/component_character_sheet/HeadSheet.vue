<template>
  <v-card height="150px" class="pa-4 character-card" color="light-blue lighten-4" outlined>
    <v-row no-gutters>
      <!-- รูป -->
      <v-col cols="12" sm="2" class="character-img">
        <v-img :src="character.image" alt="Character Picture" max-width="120" max-height="120" />
      </v-col>

      <!-- Character + Player + Gender + Race -->
      <v-col cols="12" sm="2" class="character-info">
        <strong>Character Name:</strong> {{ character.name }}<br />
        <strong>Player Name:</strong> {{ character.player }}<br />
        <strong>Gender:</strong> {{ character.gender }}<br />
        <strong>Race:</strong> {{ character.race }}<br />
        <strong>Subrace:</strong> {{ character.subrace }}
      </v-col>

      <!-- Class / Level / Exp -->
      <v-col cols="12" sm="2" class="character-info">
        <strong>Class:</strong> {{ character.class }}<br />
        <strong>Subclass:</strong> {{ character.subclass }}<br />
        <strong>Level:</strong> {{ character.level }}<br />
        <strong>EXP:</strong> {{ character.exp }}
      </v-col>
    </v-row>
  </v-card>
</template>

<script setup>
defineProps({
  character: Object
});
</script>
