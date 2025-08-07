<!-- src/components/topbar.vue -->
<template>
  <header class="top-bar">
    <nav>
      <router-link to="/">Home</router-link>
      <router-link to="/characters">Characters</router-link>
      <router-link to="/races">Races</router-link>
      <router-link to="/classes">Classes</router-link>
      <router-link to="/alignments">Alignments</router-link>
    </nav>
  </header>
</template>

<script setup>
</script>

<style scoped>
.top-bar {
  background-color: #333;
  color: white;
  padding: 1rem;
  text-align: center;
  position: top;
  top: 0;
  z-index: 1000;
}
nav {
  display: flex;
  justify-content: center;
  gap: 2rem;
}
a {
  color: white;
  text-decoration: none;
}
a.router-link-exact-active {
  font-weight: bold;
  text-decoration: underline;
}
</style>
