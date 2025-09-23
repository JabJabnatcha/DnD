<template>
  <v-card outlined>
    <v-tabs v-model="tab" bg-color="deep-purple lighten-2" dark>
      <v-tab value="actions">Actions</v-tab>
      <v-tab value="spells">Spells</v-tab>
      <v-tab value="inventory">Inventory</v-tab>
      <v-tab value="features">Features & Traits</v-tab>
      <v-tab value="background">Background</v-tab>
      <v-tab value="conditions">Conditions</v-tab>
    </v-tabs>

    <v-window v-model="tab">
      <v-window-item value="actions">
        <v-card-text>
          <div v-for="action in character.actions" :key="action.name">
            <strong>{{ action.name }}</strong>: {{ action.desc }}
          </div>
        </v-card-text>
      </v-window-item>

      <v-window-item value="spells">
        <v-card-text>
          <div v-for="spell in character.spells" :key="spell.name">
            <strong>{{ spell.level }}:</strong> {{ spell.name }}
          </div>
        </v-card-text>
      </v-window-item>

      <v-window-item value="inventory">
        <v-card-text>
          <ul>
            <li v-for="item in character.inventory" :key="item">{{ item }}</li>
          </ul>
        </v-card-text>
      </v-window-item>

      <v-window-item value="features">
        <v-card-text>
          <ul>
            <li v-for="feature in character.features" :key="feature">{{ feature }}</li>
          </ul>
        </v-card-text>
      </v-window-item>

      <v-window-item value="background">
        <v-card-text>
          <p>{{ character.background }}</p>
        </v-card-text>
      </v-window-item>

      <v-window-item value="conditions">
        <v-card-text>
          <ul>
            <li v-for="c in character.conditions" :key="c">{{ c }}</li>
          </ul>
        </v-card-text>
      </v-window-item>
    </v-window>
  </v-card>
</template>

<script setup>
import { ref } from "vue";

defineProps({
  character: Object
});

const tab = ref("actions");
</script>
