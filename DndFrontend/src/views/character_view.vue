<template>
  <topbar />
  <character-table :characters="characters" />
  <character-form @create="addCharacter" />
</template>

<script setup>
import topbar from '@/components/topbar.vue';
import characterTable from '@/components/character_table.vue';
import characterForm from '@/components/character_form.vue';
import { ref } from 'vue';

const characters = ref([
  { id: 1, name: 'Aria', race: 'Elf', class: 'Wizard', alignment: 'Good' }
]);

function addCharacter(newChar) {
  characters.value.push({ ...newChar, id: Date.now() });
}
</script>
