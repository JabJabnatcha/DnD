<template>
  <div>
    <!-- ปุ่มเปิด modal -->
    <v-btn color="primary" @click="dialog = true">Add Character</v-btn>

    <!-- Modal -->
    <v-dialog v-model="dialog" max-width="500px">
      <v-card>
        <v-card-title>
          <span class="text-h6">Create Character</span>
        </v-card-title>

        <v-card-text>
          <v-form @submit.prevent="handleSubmit" ref="formRef">
            <v-text-field v-model="form.name" label="Name" required></v-text-field>
            <v-text-field v-model="form.race" label="Race" required></v-text-field>
            <v-text-field v-model="form.class" label="Class" required></v-text-field>
            <v-text-field v-model="form.alignment" label="Alignment" required></v-text-field>
          </v-form>
        </v-card-text>

        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn text color="red" @click="dialog = false">Cancel</v-btn>
          <v-btn color="primary" @click="handleSubmit">Create</v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
  </div>
</template>

<script setup>
import { reactive, ref } from 'vue';
const emit = defineEmits(['create']);

const dialog = ref(false);
const form = reactive({
  name: '',
  race: '',
  class: '',
  alignment: ''
});

const formRef = ref(null);

function handleSubmit() {
  if (!form.name || !form.race || !form.class || !form.alignment) return;

  emit('create', { ...form });

  // reset form
  form.name = '';
  form.race = '';
  form.class = '';
  form.alignment = '';

  dialog.value = false;
}
</script>

<style scoped>
</style>
