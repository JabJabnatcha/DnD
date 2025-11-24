<template>
  <v-dialog v-model="dialog" max-width="600">
    <v-card>
      <v-card-title>Create New Character</v-card-title>
      <v-card-text>
        <v-form @submit.prevent="submitCharacter">
          <!-- Basic Info -->
          <v-text-field
            label="Name"
            v-model="newCharacter.name"
            dense
            outlined
            required
          />
          <v-text-field
            label="Race"
            v-model="newCharacter.race"
            dense
            outlined
          />
          <v-text-field
            label="Class"
            v-model="newCharacter.class"
            dense
            outlined
          />

          <!-- Progression -->
          <v-text-field
            label="Level"
            type="number"
            v-model="newCharacter.level"
            dense
            outlined
          />
          <v-text-field
            label="Experience"
            type="number"
            v-model="newCharacter.experience"
            dense
            outlined
          />

          <!-- Ability Scores -->
          <v-text-field
            label="Strength"
            type="number"
            v-model="newCharacter.strength"
            dense
            outlined
          />
          <v-text-field
            label="Dexterity"
            type="number"
            v-model="newCharacter.dexterity"
            dense
            outlined
          />
          <v-text-field
            label="Constitution"
            type="number"
            v-model="newCharacter.constitution"
            dense
            outlined
          />
          <v-text-field
            label="Intelligence"
            type="number"
            v-model="newCharacter.intelligence"
            dense
            outlined
          />
          <v-text-field
            label="Wisdom"
            type="number"
            v-model="newCharacter.wisdom"
            dense
            outlined
          />
          <v-text-field
            label="Charisma"
            type="number"
            v-model="newCharacter.charisma"
            dense
            outlined
          />

          <v-card-actions>
            <v-spacer></v-spacer>
            <v-btn text @click="dialog = false">Cancel</v-btn>
            <v-btn color="primary" type="submit">Create</v-btn>
          </v-card-actions>
        </v-form>
      </v-card-text>
    </v-card>
  </v-dialog>
</template>

<script setup>
import { ref } from "vue";
import axios from "axios";
import {
  VDialog,
  VCard,
  VCardTitle,
  VCardText,
  VCardActions,
  VTextField,
  VBtn,
  VSpacer,
  VForm,
} from "vuetify/components";

const dialog = ref(false);

const newCharacter = ref({
  name: "",
  race: "",
  class: "",
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
  isDeleted: false,
});

// Emit event ให้ parent รีเฟรช table
const emit = defineEmits(["created"]);

const submitCharacter = async () => {
  try {
    await axios.post("http://localhost:5199/api/Character", newCharacter.value);
    dialog.value = false;

    // รีเซ็ต form
    Object.assign(newCharacter.value, {
      name: "",
      race: "",
      class: "",
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
      isDeleted: false,
    });

    emit("created");
  } catch (err) {
    console.error(err);
  }
};

// ให้ parent เรียกเปิด modal
defineExpose({
  openDialog: () => {
    dialog.value = true;
  },
});
</script>
