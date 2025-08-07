<template>
  <form @submit.prevent="handleSubmit" class="character-form">
    <input v-model="form.name" placeholder="Name" required />
    <input v-model="form.race" placeholder="Race" required />
    <input v-model="form.class" placeholder="Class" required />
    <input v-model="form.alignment" placeholder="Alignment" required />
    <button type="submit">Create</button>
  </form>
</template>

<script setup>
import { reactive } from 'vue';
const emit = defineEmits(['create']);
const form = reactive({
  name: '',
  race: '',
  class: '',
  alignment: ''
});

function handleSubmit() {
  emit('create', { ...form });
  form.name = '';
  form.race = '';
  form.class = '';
  form.alignment = '';
}
</script>

<style scoped>
.character-form {
  margin-top: 2rem;
  display: flex;
  gap: 1rem;
}
.character-form input {
  padding: 0.5rem;
}
</style>
