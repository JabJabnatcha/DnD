<template>
  <v-dialog v-model="dialog" max-width="400">
    <v-card>
      <v-card-title class="text-h6">Confirm Delete</v-card-title>
      <v-card-text>
        Are you sure you want to delete <strong>{{ characterName }}</strong
        >?
      </v-card-text>
      <v-card-actions>
        <v-spacer></v-spacer>
        <v-btn text @click="dialog = false">Cancel</v-btn>
        <v-btn
          color="error"
          @click="
            () => {
              console.log('Delete clicked');
              confirmDelete();
            }
          "
          >Delete</v-btn
        >
      </v-card-actions>
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
const characterId = ref(null);
const characterName = ref("");

const emit = defineEmits(["deleted"]);

const openDialog = (id, name) => {
  characterId.value = id;
  characterName.value = name;
  dialog.value = true;
};

const confirmDelete = async () => {
  if (!characterId.value) return;
  console.log("Deleting character id:", characterId.value); // debug
  try {
    await axios.delete(
      `http://localhost:5199/api/Character/${characterId.value}`
    );
    dialog.value = false;
    emit("deleted");
  } catch (err) {
    console.error(err);
  }
};

defineExpose({ openDialog });
</script>
