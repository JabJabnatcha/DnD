<template>
  <v-card class="pa-4 mb-2" outlined>
    <div class="text-h6">Buff & Condition</div>
    <ul>
      <li v-for="buff in buffs" :key="buff">{{ buff }}</li>
    </ul>
  </v-card>
</template>

<script setup>
defineProps({
  buffs: Array
});
</script>
