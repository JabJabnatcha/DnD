<!-- character_sheet.vue -->
<template>
  <v-container class="pa-4" v-if="character">
    <v-row dense>
      <v-col cols="12" md="3">
        <v-card outlined class="pa-4">
          <v-card-title>{{ character.name }}</v-card-title>
        </v-card>
      </v-col>

      <v-col cols="12" md="3">
        <v-card outlined class="pa-4">
          <v-card-text>
            <h3>Class & Level</h3>
            <p>{{ character.class }} Lv.{{ character.level }}</p>
            <p>{{ character.subclass }}</p>
            <v-divider class="my-2"></v-divider>
            <h3>Race</h3>
            <p>{{ character.race }}</p>
            <p>{{ character.subrace || '-' }}</p>
          </v-card-text>
        </v-card>
      </v-col>

      <v-col cols="12" md="3">
        <v-card outlined class="pa-4">
          <v-card-text>
            <h3>Background</h3>
            <p>{{ character.background }}</p>
            <v-divider class="my-2"></v-divider>
            <h3>Alignment</h3>
            <p>{{ character.alignment }}</p>
          </v-card-text>
        </v-card>
      </v-col>

      <v-col cols="12" md="3">
        <v-card outlined class="pa-4">
          <v-card-text>
            <h3>Player</h3>
            <p>{{ character.player }}</p>
            <v-divider class="my-2"></v-divider>
            <h3>EXP</h3>
            <p>{{ character.exp }}</p>
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script setup>
defineProps(['character']);
</script>
