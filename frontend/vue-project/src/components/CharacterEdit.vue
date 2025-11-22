<template>
  <v-dialog v-model="dialog" max-width="600">
    <v-card>
      <v-card-title>Edit Character</v-card-title>
      <v-card-text>
        <v-form @submit.prevent="updateCharacter">

          <!-- Basic Info -->
          <v-text-field label="Name" v-model="editCharacter.name" dense outlined required />
          <v-text-field label="Race" v-model="editCharacter.race" dense outlined />
          <v-text-field label="Class" v-model="editCharacter.class" dense outlined />
          
          <!-- Progression -->
          <v-text-field label="Level" type="number" v-model="editCharacter.level" dense outlined />
          <v-text-field label="Experience" type="number" v-model="editCharacter.experience" dense outlined />

          <!-- Ability Scores -->
          <v-text-field label="Strength" type="number" v-model="editCharacter.strength" dense outlined />
          <v-text-field label="Dexterity" type="number" v-model="editCharacter.dexterity" dense outlined />
          <v-text-field label="Constitution" type="number" v-model="editCharacter.constitution" dense outlined />
          <v-text-field label="Intelligence" type="number" v-model="editCharacter.intelligence" dense outlined />
          <v-text-field label="Wisdom" type="number" v-model="editCharacter.wisdom" dense outlined />
          <v-text-field label="Charisma" type="number" v-model="editCharacter.charisma" dense outlined />

          <!-- Actions -->
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

const dialog = ref(false);

/* ------------------------------------
   Form Model เหมือน Create แต่เพิ่ม id
--------------------------------------*/
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

/* -----------------------
   ส่ง event กลับไป parent
------------------------*/
const emit = defineEmits(['updated']);

const openDialog = (character) => {
  Object.assign(editCharacter.value, character);
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
