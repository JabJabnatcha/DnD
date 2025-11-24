<template>
  <v-dialog v-model="dialog" max-width="600">
    <v-card>
      <v-card-title>Edit Character</v-card-title>
      <v-card-text>
        <v-form @submit.prevent="updateCharacter">

          <!-- BASIC INFO -->
          <div class="row-field">
            <v-checkbox v-model="editTable.name" hide-details />
            <v-text-field label="Name" v-model="editCharacter.name" :disabled="!editTable.name" dense outlined
              required />
          </div>

          <div class="row-field">
            <v-checkbox v-model="editTable.race" hide-details />
            <v-text-field label="Race" v-model="editCharacter.race" :disabled="!editTable.race" dense outlined />
          </div>

          <div class="row-field">
            <v-checkbox v-model="editTable.class" hide-details />
            <v-text-field label="Class" v-model="editCharacter.class" :disabled="!editTable.class" dense outlined />
          </div>

          <!-- PROGRESSION -->
          <div class="row-field">
            <v-checkbox v-model="editTable.level" hide-details />
            <v-text-field label="Level" type="number" v-model="editCharacter.level" :disabled="!editTable.level" dense
              outlined />
          </div>

          <div class="row-field">
            <v-checkbox v-model="editTable.experience" hide-details />
            <v-text-field label="Experience" type="number" v-model="editCharacter.experience"
              :disabled="!editTable.experience" dense outlined />
          </div>

          <!-- ABILITY SCORES -->
          <div class="row-field">
            <v-checkbox v-model="editTable.strength" hide-details />
            <v-text-field label="Strength" type="number" v-model="editCharacter.strength"
              :disabled="!editTable.strength" dense outlined />
          </div>

          <div class="row-field">
            <v-checkbox v-model="editTable.dexterity" hide-details />
            <v-text-field label="Dexterity" type="number" v-model="editCharacter.dexterity"
              :disabled="!editTable.dexterity" dense outlined />
          </div>

          <div class="row-field">
            <v-checkbox v-model="editTable.constitution" hide-details />
            <v-text-field label="Constitution" type="number" v-model="editCharacter.constitution"
              :disabled="!editTable.constitution" dense outlined />
          </div>

          <div class="row-field">
            <v-checkbox v-model="editTable.intelligence" hide-details />
            <v-text-field label="Intelligence" type="number" v-model="editCharacter.intelligence"
              :disabled="!editTable.intelligence" dense outlined />
          </div>

          <div class="row-field">
            <v-checkbox v-model="editTable.wisdom" hide-details />
            <v-text-field label="Wisdom" type="number" v-model="editCharacter.wisdom" :disabled="!editTable.wisdom"
              dense outlined />
          </div>

          <div class="row-field">
            <v-checkbox v-model="editTable.charisma" hide-details />
            <v-text-field label="Charisma" type="number" v-model="editCharacter.charisma"
              :disabled="!editTable.charisma" dense outlined />
          </div>


          <!-- ACTIONS -->
          <v-card-actions>
            <v-spacer></v-spacer>
            <v-btn text @click="dialog = false">Cancel</v-btn>
            <v-btn color="primary" type="submit">Update</v-btn>
          </v-card-actions>

        </v-form>
      </v-card-text>
    </v-card>
  </v-dialog>
</template>

<script setup>
import { ref } from 'vue';
import axios from 'axios';
import {
  VDialog, VCard, VCardTitle, VCardText, VCardActions,
  VTextField, VBtn, VSpacer, VForm, VCheckbox
} from 'vuetify/components';

const dialog = ref(false);

const editCharacter = ref({
  characterId: null,
  name: '',
  race: '',
  class: '',
  level: 1,
  experience: 0,
  strength: 0,
  dexterity: 0,
  constitution: 0,
  intelligence: 0,
  wisdom: 0,
  charisma: 0,
  maxHP: 0,
  currentHP: 0,
  maxMP: 0,
  currentMP: 0,
  armorClass: 0,
  initiative: 0,
  speed: 30,
  items: [],
  spells: [],
  isDeleted: false
});

const editTable = ref({
  name: false,
  race: false,
  class: false,
  level: false,
  experience: false,
  strength: false,
  dexterity: false,
  constitution: false,
  intelligence: false,
  wisdom: false,
  charisma: false
});

const emit = defineEmits(['updated']);

const openDialog = (character) => {
  Object.assign(editCharacter.value, character);

  Object.keys(editTable.value).forEach(key => {
    editTable.value[key] = false;
  });

  dialog.value = true;
};

const updateCharacter = async () => {
  try {
    await axios.put(
      `http://localhost:5199/api/Character/${editCharacter.value.characterId}`,
      editCharacter.value
    );

    dialog.value = false;
    emit('updated');

  } catch (err) {
    console.error(err);
  }
};

defineExpose({ openDialog });
</script>
