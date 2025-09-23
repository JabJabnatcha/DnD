<template>
  <div class="character_sheet-page">
    <Topbar />

    <!-- ช่องว่างซ้าย 1/12 -->
    <v-row justify="center">
      <v-col cols="0.5"></v-col>

      <!-- Container 11/12 -->
      <v-col cols="11">
        <v-row>
          <v-col cols="12" >
            <HeadSheet :character="character" />
          </v-col>
        </v-row>

        <!-- Row 2: Status & Secondary Info -->
        <v-row>
          <!-- ด้านซ้าย: Status -->
          <v-col cols="6">
            <Status :character="character" :abilities="abilitiesWithMod" />
          </v-col>

          <!-- ด้านขวา: SavingThrows, Senses, Proficiencies -->
          <v-col cols="6">
            <SavingThrows :character="character" />
            <Senses :senses="character.senses" />
            <ProficienciesTraining :proficiencies="character.proficienciesAndTraining" />
          </v-col>
        </v-row>

        <!-- Row 3: Skills + Initiative/AC/Buff -->
        <v-row>
          <!-- ด้านซ้าย: Skills -->
          <v-col cols="6">
            <Skills :skills="skillsWithBonus" />
          </v-col>

          <!-- ด้านขวา: Initiative, ArmorClass, BuffCondition -->
          <v-col cols="6">
            <v-row>
              <v-col cols="12" sm="4">
                <Initiative :initiative="character.initiative" />
              </v-col>
              <v-col cols="12" sm="4">
                <ArmorClass :ac="character.ac" />
              </v-col>
              <v-col cols="12" sm="4">
                <BuffCondition :conditions="character.conditions" />
              </v-col>
            </v-row>
          </v-col>
        </v-row>

        <!-- Row 4: TabsPanel -->
        <v-row>
          <v-col cols="12">
            <TabsPanel :character="character" />
          </v-col>
        </v-row>
      </v-col>

      <!-- ช่องว่างขวา 1/12 -->
      <v-col cols="0.5"></v-col>
    </v-row>
  </div>
</template>


<script setup>
import { computed } from "vue";
import Topbar from "../components/topbar.vue";
import HeadSheet from "../components/component_character_sheet/HeadSheet.vue";
import Status from "../components/component_character_sheet/Status.vue";
import SavingThrows from "../components/component_character_sheet/SavingThrows.vue";
import Senses from "../components/component_character_sheet/Senses.vue";
import ProficienciesTraining from "../components/component_character_sheet/ProficienciesTraining.vue";
import Skills from "../components/component_character_sheet/Skill.vue";
import Initiative from "../components/component_character_sheet/Initiative.vue";
import ArmorClass from "../components/component_character_sheet/ArmorClass.vue";
import BuffCondition from "../components/component_character_sheet/BuffCondition.vue";
import TabsPanel from "../components/component_character_sheet/TabsPanel.vue";


import cmImg from "@/assets/cm.jpg";

// C:\Users\Laptop-JAB\Desktop\Learn\DnD\DndFrontend\src\components\component_character_sheet\ArmorClass.vue

// ✅ Character Data
const character = {
  id: 1,
  player: "Alice",
  name: "Aria",
  gender: "Female",
  race: "Elf",
  subrace: "High Elf",
  class: "Wizard",
  subclass: "Evocation",
  level: 3,
  exp: 1200,
  image: cmImg,
  abilities: [
    { name: "Strength", score: 10 },
    { name: "Dexterity", score: 8 },
    { name: "Constitution", score: 7 },
    { name: "Intelligence", score: 19 },
    { name: "Wisdom", score: 20 },
    { name: "Charisma", score: 20 },
  ],
  proficiencyBonus: 2,
  walkingSpeed: 30,
  heroicInspiration: 1,
  currentHP: 25,
  maxHP: 30,
  tempHP: 5,
  initiative: 2,
  ac: 15,
  conditions: ["Blessed", "Invisible"],

  SavingThrows_STR: 0,
  SavingThrows_DEX: -1,
  SavingThrows_CON: -2,
  SavingThrows_INT: 4,
  SavingThrows_WIS: 5,
  SavingThrows_CHA: 5,

  senses: {
    darkvision: "60 ft",
    passivePerception: 15,
  },

  proficienciesAndTraining: {
    weapons: ["Daggers", "Shortswords"],
    tools: ["Thieves' Tools"],
    languages: ["Common", "Elvish"],
  },

  skills: [
    { name: "Athletics", ability: "Strength", prof: false },
    { name: "Acrobatics", ability: "Dexterity", prof: false },
    { name: "Sleight of Hand", ability: "Dexterity", prof: true },
    { name: "Stealth", ability: "Dexterity", prof: false },
    { name: "Arcana", ability: "Intelligence", prof: true },
    { name: "History", ability: "Intelligence", prof: false },
    { name: "Investigation", ability: "Intelligence", prof: false },
    { name: "Nature", ability: "Intelligence", prof: false },
    { name: "Religion", ability: "Intelligence", prof: false },
    { name: "Animal Handling", ability: "Wisdom", prof: false },
    { name: "Insight", ability: "Wisdom", prof: true },
    { name: "Medicine", ability: "Wisdom", prof: false },
    { name: "Perception", ability: "Wisdom", prof: true },
    { name: "Survival", ability: "Wisdom", prof: false },
    { name: "Deception", ability: "Charisma", prof: false },
    { name: "Intimidation", ability: "Charisma", prof: false },
    { name: "Performance", ability: "Charisma", prof: false },
    { name: "Persuasion", ability: "Charisma", prof: false },
  ],

  actions: [
    { name: "Fire Bolt", desc: "Ranged spell attack, 1d10 fire damage" },
    { name: "Quarterstaff", desc: "Melee attack, 1d6 bludgeoning" },
  ],
  spells: [
    { level: 1, name: "Magic Missile" },
    { level: 2, name: "Mirror Image" },
  ],
  inventory: ["Quarterstaff", "Spellbook", "Rope"],
  features: ["Arcane Recovery", "Sculpt Spells"],
  background: "Sage scholar of ancient lore.",
};

const abilitiesWithMod = computed(() =>
  character.abilities.map((a) => ({
    ...a,
    mod: Math.floor((a.score - 10) / 2),
  }))
);

const skillsWithBonus = computed(() =>
  character.skills.map((s) => {
    const ability = abilitiesWithMod.value.find((a) => a.name === s.ability);
    const baseMod = ability ? ability.mod : 0;
    const bonus = baseMod + (s.prof ? character.proficiencyBonus : 0);
    return { ...s, mod: baseMod, bonus };
  })
);
</script>

<style scoped>
.character_sheet-page {
  width: 100vw;
  min-height: 100vh;
  display: flex;
  flex-direction: column;
}
</style>