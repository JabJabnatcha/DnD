<template>
  <v-row class="row2">
    <v-card class="static-card_HP Ash" outlined>
      <strong>Proficiency Bonus</strong>
      <div class="stat-value">{{ character.proficiencyBonus }}</div>
    </v-card>

    <v-card class="static-card Ash" outlined>
      <strong>Walking Speed</strong>
      <div class="stat-value">{{ character.walkingSpeed }} ft</div>
    </v-card>

    <v-card class="static-card_HP Ash" outlined>
      <strong>Heroic Inspiration</strong>
      <div class="stat-value">{{ character.heroicInspiration }}</div>
    </v-card>

    <v-card class="static-card_HP constitution" outlined>
      <strong>Hit Points</strong>
      <div class="stat-value">
        {{ character.currentHP }} / {{ character.maxHP }}
        <span v-if="character.tempHP">(+{{ character.tempHP }} temp)</span>
      </div>
    </v-card>
  </v-row>
</template>

<script setup>
defineProps({
  character: Object
});
</script>
