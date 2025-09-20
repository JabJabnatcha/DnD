<!-- src/views/CharacterSheetView.vue -->
<template>
  <topbar />

  <v-container class="pa-4" v-if="character">
    <v-btn color="primary" class="mb-4" @click="$router.push('/characters')">
      ← Back to Characters
    </v-btn>

    <!-- Character Basic Info -->
    <v-row dense>
      <v-col cols="12" md="6">
        <v-card outlined class="pa-4">
          <v-card-title>{{ character.name }} (Player: {{ character.player }})</v-card-title>
          <v-card-subtitle>
            Level {{ character.level }} {{ character.class }} ({{ character.subclass || '-' }})
          </v-card-subtitle>
          <v-card-text>
            Race: {{ character.race }} {{ character.subrace || '' }} <br>
            Background: {{ character.background }} <br>
            Alignment: {{ character.alignment }}
          </v-card-text>
        </v-card>
      </v-col>
      <v-col cols="12" md="6">
        <v-card outlined class="pa-4 text-center">
          <v-card-title>Stats</v-card-title>
          <v-row dense>
            <v-col v-for="(value, key) in character.stats" :key="key" cols="4" class="text-center">
              <strong>{{ key }}</strong>
              <p>{{ value }}</p>
            </v-col>
          </v-row>
        </v-card>
      </v-col>
    </v-row>

    <!-- Combat Info -->
    <v-row dense class="mt-4">
      <v-col cols="12" md="4">
        <v-card outlined class="pa-4">
          <v-card-title>HP / AC / Speed</v-card-title>
          <v-card-text>
            HP: {{ character.hp }} <br>
            AC: {{ character.ac }} <br>
            Speed: {{ character.speed }} ft
          </v-card-text>
        </v-card>
      </v-col>
      <v-col cols="12" md="4">
        <v-card outlined class="pa-4">
          <v-card-title>Proficiencies</v-card-title>
          <v-card-text>
            <ul>
              <li v-for="prof in character.proficiencies" :key="prof">{{ prof }}</li>
            </ul>
          </v-card-text>
        </v-card>
      </v-col>
      <v-col cols="12" md="4">
        <v-card outlined class="pa-4">
          <v-card-title>Saving Throws</v-card-title>
          <v-card-text>
            <ul>
              <li v-for="(val, st) in character.savingThrows" :key="st">{{ st }}: {{ val }}</li>
            </ul>
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>

    <!-- Skills -->
    <v-row dense class="mt-4">
      <v-col cols="12">
        <v-card outlined class="pa-4">
          <v-card-title>Skills</v-card-title>
          <v-row dense>
            <v-col v-for="(val, skill) in character.skills" :key="skill" cols="4">
              <strong>{{ skill }}</strong>: {{ val }}
            </v-col>
          </v-row>
        </v-card>
      </v-col>
    </v-row>

    <!-- Spells / Abilities -->
    <v-row dense class="mt-4">
      <v-col cols="12" md="6">
        <v-card outlined class="pa-4">
          <v-card-title>Spells / Features</v-card-title>
          <v-card-text>
            <ul>
              <li v-for="spell in character.spells" :key="spell">{{ spell }}</li>
            </ul>
          </v-card-text>
        </v-card>
      </v-col>

      <!-- Equipment -->
      <v-col cols="12" md="6">
        <v-card outlined class="pa-4">
          <v-card-title>Equipment</v-card-title>
          <v-card-text>
            <ul>
              <li v-for="item in character.equipment" :key="item">{{ item }}</li>
            </ul>
          </v-card-text>
        </v-card>
      </v-col>
    </v-row>
  </v-container>

  <p v-else>Character not found.</p>
</template>

<script setup>
import topbar from '@/components/topbar.vue';
import { ref, computed } from 'vue';
import { useRoute } from 'vue-router';

// ดึง id จาก URL
const route = useRoute();
const characterId = Number(route.params.id);

// ตัวอย่างข้อมูล character แบบ D&D 5e
const characters = ref([
  {
    id: 1,
    player: 'Alice',
    name: 'Aria',
    race: 'Elf',
    subrace: 'High Elf',
    class: 'Wizard',
    subclass: 'Evoker',
    level: 3,
    background: 'Sage',
    alignment: 'Good',
    exp: '200/300',
    hp: 18,
    ac: 12,
    speed: 30,
    stats: { STR: 8, DEX: 14, CON: 12, INT: 18, WIS: 10, CHA: 10 },
    savingThrows: { INT: '+5', WIS: '+0' },
    proficiencies: ['Arcana', 'History', 'Investigation'],
    skills: { Arcana: '+5', History: '+5', Investigation: '+5', Perception: '+2' },
    spells: ['Magic Missile', 'Fireball', 'Shield'],
    equipment: ['Quarterstaff', 'Spellbook', 'Backpack']
  },
  {
    id: 2,
    player: 'Bob',
    name: 'Borin',
    race: 'Dwarf',
    subrace: 'Mountain Dwarf',
    class: 'Fighter',
    subclass: 'Champion',
    level: 2,
    background: 'Soldier',
    alignment: 'Neutral',
    exp: '150/250',
    hp: 20,
    ac: 16,
    speed: 25,
    stats: { STR: 16, DEX: 10, CON: 14, INT: 10, WIS: 12, CHA: 8 },
    savingThrows: { STR: '+5', CON: '+4' },
    proficiencies: ['Athletics', 'Intimidation'],
    skills: { Athletics: '+5', Intimidation: '+2', Perception: '+1' },
    spells: [],
    equipment: ['Longsword', 'Shield', 'Chain Mail']
  }
]);

const character = computed(() => characters.value.find(c => c.id === characterId) || null);
</script>

<style scoped>
.v-card-title {
  font-weight: bold;
  font-size: 1.2rem;
}
.v-card-text {
  font-size: 0.95rem;
}
</style>
