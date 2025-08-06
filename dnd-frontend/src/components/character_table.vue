<template>
  <table class="character-table">
    <thead>
      <tr>
        <th>Name</th>
        <th>Race</th>
        <th>Class</th>
        <th>Alignment</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="char in characters" :key="char.id">
        <td>{{ char.name }}</td>
        <td>{{ char.race }}</td>
        <td>{{ char.class }}</td>
        <td>{{ char.alignment }}</td>
      </tr>
    </tbody>
  </table>
</template>

<script setup>
defineProps(['characters']);
</script>

<style scoped>
.character-table {
  width: 100%;
  border-collapse: collapse;
  margin-top: 1rem;
}
.character-table th, .character-table td {
  border: 1px solid #ccc;
  padding: 0.5rem;
}
</style>
