<!-- src/components/topbar.vue -->
<template>
  <v-app-bar app color="primary" dark>
    <v-toolbar-title>My App</v-toolbar-title>
    <v-spacer></v-spacer>
    <v-btn text to="/">Home</v-btn>
    <v-btn text to="/races">Races</v-btn>
    <v-btn text to="/classes">Classes</v-btn>
    <v-btn text to="/alignments">Alignments</v-btn>
    <v-btn text to="/characters">Characters</v-btn>
  </v-app-bar>
</template>

<script setup>
// ไม่ต้องใช้ ref, onMounted, onUnmounted แล้ว
</script>

