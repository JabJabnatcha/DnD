<template>
  <v-card class="pa-4 mt-2" color="light-green lighten-4" outlined>
    <strong>Skills</strong>
    <div v-for="skill in skills" :key="skill.name" class="mb-1">
      <strong>{{ skill.name }}</strong>
      ({{ skill.ability.substring(0, 3).toUpperCase() }}) :
      <span :style="{ color: skill.prof ? 'blue' : 'black' }">
        {{ skill.prof ? '[P]' : '' }} Mod: {{ skill.mod }},
        Bonus: {{ skill.bonus >= 0 ? '+' + skill.bonus : skill.bonus }}
      </span>
    </div>
  </v-card>
</template>

<script setup>
defineProps({
  skills: Array
});
</script>
