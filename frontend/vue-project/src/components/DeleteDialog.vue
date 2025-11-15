<template>
  <v-dialog v-model="visible" max-width="400">
    <v-card>
      <v-card-title>Confirm Delete</v-card-title>
      <v-card-text>
        Are you sure you want to delete <strong>{{ character.name }}</strong>?
      </v-card-text>
      <v-card-actions>
        <v-spacer></v-spacer>
        <v-btn text @click="$emit('close')">Cancel</v-btn>
        <v-btn color="red" text @click="$emit('confirm')">Delete</v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script>
export default {
  props: ['character'],
  data() {
    return { visible: true };
  },
};
</script>
