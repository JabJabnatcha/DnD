<!-- src/views/character_view.vue -->
<template>
  <div class="character-page">
    <topbar />

    
      <character-table :characters="characters" />
    
  </div>
</template>

<script setup>
import { ref } from 'vue';
import Topbar from '../components/topbar.vue';
import CharacterTable from '../components/character_table.vue';

const characters = ref([
  { id: 1, player: 'Alice', name: 'Aria', race: 'Elf', class: 'Wizard', level: 3, alignment: 'Good' },
  { id: 2, player: 'Bob', name: 'Borin', race: 'Dwarf', class: 'Fighter', level: 2, alignment: 'Neutral' },
  { id: 3, player: 'Charlie', name: 'Cora', race: 'Human', class: 'Cleric', level: 4, alignment: 'Lawful' }
]);
</script>

<style scoped>
.character-page {
  width: 100vw;
  min-height: 100vh;
  display: flex;
  flex-direction: column;
}

.table-container {
  flex: 1;
  padding: 1rem 2rem;
  width: 100%;
}
</style>
