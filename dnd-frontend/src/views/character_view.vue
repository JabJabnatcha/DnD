<template>
  <TopBar />
  <CharacterTable :characters="characters" />
  <CharacterForm @create="addCharacter" />
</template>

<script setup>
import TopBar from '@/components/TopBar.vue';
import CharacterTable from '@/components/CharacterTable.vue';
import CharacterForm from '@/components/CharacterForm.vue';
import { ref } from 'vue';

const characters = ref([
  { id: 1, name: 'Aria', race: 'Elf', class: 'Wizard', alignment: 'Good' }
]);

function addCharacter(newChar) {
  characters.value.push({ ...newChar, id: Date.now() });
}
</script>
