<!-- src/views/CharacterSheetView.vue -->
<template>
  <div class="character_sheet-page">
    <topbar />
    <v-row justify="center">
      <!-- ช่องว่างซ้าย 1/12 -->
      <v-col cols="0.5"></v-col>

      <!-- Container 10/12 -->
      <v-col cols="11" style="background-color: black">
        <!-- Row 1: Character Cards -->
        <v-row class="row1" key="character.id">
          <v-col cols="12">
            <v-card height="150px" class="pa-4 character-card" color="light-blue lighten-4" outlined>
              <v-row no-gutters>
                <!-- 1. รูป -->
                <v-col cols="12" sm="2" class="character-img">
                  <v-img :src="character.image" alt="Character Picture" max-width="120" max-height="120"></v-img>
                </v-col>

                <!-- 2. Character Name + Player -->
                <!-- 3. Gender, Race, Subrace -->
                <v-col cols="12" sm="2" class="character-info">
                  <strong>Character Name:</strong> {{ character.name }}<br />
                  <strong>Player Name:</strong> {{ character.player }}<br />
                  <strong>Gender:</strong> {{ character.gender }}<br />
                  <strong>Race:</strong> {{ character.race }}<br />
                  <strong>Subrace:</strong> {{ character.subrace }}<br />
                </v-col>
                <!-- 4. Class, Subclass, Level, Exp -->
                <v-col cols="12" sm="2" class="character-info">
                  <strong>Class:</strong> {{ character.class }}<br />
                  <strong>Subclass:</strong> {{ character.subclass }}<br />
                  <strong>Level:</strong> {{ character.level }}<br />
                  <strong>EXP:</strong> {{ character.exp }}<br />
                </v-col>
              </v-row>
            </v-card>
          </v-col>
        </v-row>

        <!-- Row 2: Secondary Info -->
        <v-row>
          <!-- ด้านซ้าย: Ability Scores -->
          <v-col cols="6">
            <v-row class="row2">
              <v-card class="ability-card strength" outlined>
                <strong>Strength</strong>
                <div class="score">{{ abilitiesWithMod[0].score }}</div>
                <div class="modifier">
                  Modifier: {{ abilitiesWithMod[0].mod }}
                </div>
              </v-card>
              <v-card class="ability-card dexterity" outlined>
                <strong>Dexterity</strong>
                <div class="score">{{ abilitiesWithMod[1].score }}</div>
                <div class="modifier">
                  Modifier: {{ abilitiesWithMod[1].mod }}
                </div>
              </v-card>
              <v-card class="ability-card constitution" outlined>
                <strong>Constitution</strong>
                <div class="score">{{ abilitiesWithMod[2].score }}</div>
                <div class="modifier">
                  Modifier: {{ abilitiesWithMod[2].mod }}
                </div>
              </v-card>
              <v-card class="ability-card intelligence" outlined>
                <strong>Intelligence</strong>
                <div class="score">{{ abilitiesWithMod[3].score }}</div>
                <div class="modifier">
                  Modifier: {{ abilitiesWithMod[3].mod }}
                </div>
              </v-card>
              <v-card class="ability-card wisdom" outlined>
                <strong>Wisdom</strong>
                <div class="score">{{ abilitiesWithMod[4].score }}</div>
                <div class="modifier">
                  Modifier: {{ abilitiesWithMod[4].mod }}
                </div>
              </v-card>
              <v-card class="ability-card charisma" outlined>
                <strong>Charisma</strong>
                <div class="score">{{ abilitiesWithMod[5].score }}</div>
                <div class="modifier">
                  Modifier: {{ abilitiesWithMod[5].mod }}
                </div>
              </v-card>
            </v-row>
          </v-col>
          <!-- เปลี่ยนเนื้อหาเป็น poficiency bonus, walking speed, heroic inspiration, HP -->
          <v-col cols="6">
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
          </v-col>
        </v-row>

        <!-- Row 3: Example Cards -->
        <v-row class="mb-2">
          <!-- col 1 -->
          <v-col cols="12" md="4">
            <!-- Saving Throws -->
            <v-card class="pa-4 mt-2" color="pink lighten-4" outlined>
              <strong>Saving Throws</strong>
              <div>STR: {{ character.SavingThrows_STR }}</div>
              <div>DEX: {{ character.SavingThrows_DEX }}</div>
              <div>CON: {{ character.SavingThrows_CON }}</div>
              <div>INT: {{ character.SavingThrows_INT }}</div>
              <div>WIS: {{ character.SavingThrows_WIS }}</div>
              <div>CHA: {{ character.SavingThrows_CHA }}</div>
            </v-card>

            <!-- Senses -->
            <v-card class="pa-4 mt-2" color="pink lighten-2" outlined>
              <strong>Senses</strong>
              <div>Darkvision: {{ character.senses.darkvision }}</div>
              <div>Passive Perception: {{ character.senses.passivePerception }}</div>
            </v-card>

            <!-- Proficiencies & Training -->
            <v-card class="pa-4 mt-2" color="pink lighten-1" outlined>
              <strong>Proficiencies & Training</strong>
              <div>Weapons: {{ character.proficienciesAndTraining.weapons.join(', ') }}</div>
              <div>Tools: {{ character.proficienciesAndTraining.tools.join(', ') }}</div>
              <div>Languages: {{ character.proficienciesAndTraining.languages.join(', ') }}</div>
            </v-card>
          </v-col>


          <!-- col 2 -->
          <v-col cols="12" md="4">
            <v-card class="pa-4 mt-2" color="light-green lighten-4" outlined>
              <strong>Skills</strong>
              <div v-for="skill in skillsWithBonus" :key="skill.name" class="mb-1">
                <strong>{{ skill.name }}</strong>
                ({{ skill.ability.substring(0, 3).toUpperCase() }}) :
                <span :style="{ color: skill.prof ? 'blue' : 'black' }">
                  {{ skill.prof ? '[P]' : '' }} Mod: {{ skill.mod }},
                  Bonus: {{ skill.bonus >= 0 ? '+' + skill.bonus : skill.bonus }}
                </span>
              </div>
            </v-card>
          </v-col>

          <!-- col 3 -->
          <v-col cols="12" md="4">
            <v-row>
              <v-col cols="12" sm="4">
                <v-card class="pa-4 mb-2" outlined>
                  <div class="text-h6">Initiative</div>
                  <div>{{ character.initiative }}</div>
                </v-card>
              </v-col>
              <v-col cols="12" sm="4">
                <v-card class="pa-4 mb-2" outlined>
                  <div class="text-h6">Armor Class</div>
                  <div>{{ character.ac }}</div>
                </v-card>
              </v-col>
              <v-col cols="12" sm="4">
                <v-card class="pa-4 mb-2" outlined>
                  <div class="text-h6">Buff & Condition</div>
                  <ul>
                    <li v-for="buff in character.conditions" :key="buff">{{ buff }}</li>
                  </ul>
                </v-card>
              </v-col>
            </v-row>

            <!-- Panel หลักแบบ Tab -->
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
          </v-col>


          <!-- Panel หลักแบบ Tab -->
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
import cmImg from "@/assets/cm.jpg";

// รวมทุกอย่างไว้ใน object ตัวเดียว
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

  // Core Stats
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

  // HP
  currentHP: 25,
  maxHP: 30,
  tempHP: 5,

  // Initiative & AC
  initiative: 2,
  ac: 15,

  // Saving Throws
  SavingThrows_STR: 0,
  SavingThrows_DEX: -1,
  SavingThrows_CON: -2,
  SavingThrows_INT: 4,
  SavingThrows_WIS: 5,
  SavingThrows_CHA: 5,

  // Senses
  senses: {
    darkvision: "60 ft",
    passivePerception: 15,
    passiveInvestigation: 12,
    passiveInsight: 13,
  },

  // Proficiencies
  proficienciesAndTraining: {
    weapons: ["Daggers", "Shortswords"],
    armor: ["None"], // Wizard ไม่คล่องชุดเกราะ
    tools: ["Thieves' Tools"],
    savingThrows: ["Intelligence", "Wisdom"],
    skills: ["Arcana", "Insight", "Perception"],
    languages: ["Common", "Elvish", "Draconic"],
  },

  // Skills
  skills: [
    // STR
    { name: "Athletics", ability: "Strength", prof: false },
    // DEX
    { name: "Acrobatics", ability: "Dexterity", prof: false },
    { name: "Sleight of Hand", ability: "Dexterity", prof: true },
    { name: "Stealth", ability: "Dexterity", prof: false },
    // INT
    { name: "Arcana", ability: "Intelligence", prof: true },
    { name: "History", ability: "Intelligence", prof: false },
    { name: "Investigation", ability: "Intelligence", prof: false },
    { name: "Nature", ability: "Intelligence", prof: false },
    { name: "Religion", ability: "Intelligence", prof: false },
    // WIS
    { name: "Animal Handling", ability: "Wisdom", prof: false },
    { name: "Insight", ability: "Wisdom", prof: true },
    { name: "Medicine", ability: "Wisdom", prof: false },
    { name: "Perception", ability: "Wisdom", prof: true },
    { name: "Survival", ability: "Wisdom", prof: false },
    // CHA
    { name: "Deception", ability: "Charisma", prof: false },
    { name: "Intimidation", ability: "Charisma", prof: false },
    { name: "Performance", ability: "Charisma", prof: false },
    { name: "Persuasion", ability: "Charisma", prof: false },
  ],

  // Combat / Actions
  actions: [
    { name: "Quarterstaff", desc: "+2 to hit, 1d6 bludgeoning" },
    { name: "Fire Bolt", desc: "+5 to hit, 1d10 fire damage" },
  ],

  // Spells
  spellcasting: {
    ability: "Intelligence",
    spellSaveDC: 14,
    spellAttackBonus: 6,
    slots: { 1: 4, 2: 2, 3: 0 }, // ใช้แล้ว/สูงสุดต่อ level
  },
  spells: [
    { name: "Mage Armor", level: 1 },
    { name: "Magic Missile", level: 1 },
    { name: "Shield", level: 1 },
    { name: "Mirror Image", level: 2 },
    { name: "Misty Step", level: 2 },
    { name: "Fireball", level: 3 },
  ],

  // Inventory
  inventory: [
    { item: "Backpack", qty: 1 },
    { item: "Potion of Healing", qty: 2 },
    { item: "Rope (50ft)", qty: 1 },
    { item: "Spellbook", qty: 1 },
  ],

  // Features & Traits
  features: [
    "Darkvision",
    "Fey Ancestry (advantage on charm saves, immune to sleep)",
    "Arcane Recovery (regain spell slots after short rest)",
  ],

  // Background
  background: "Sage - Spent years in pursuit of arcane knowledge.",

  // Buffs & Conditions
  conditions: ["Blessed"],
};

// คำนวณ modifier ของ abilities
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

.character-card .character-info {
  text-align: left;
  /* ชิดซ้าย */
  align-self: flex-start;
  /* ชิดบน */
}

.character-card .character-img {
  display: flex;
  justify-content: center;
  /* รูปอยู่กลางแนวนอน */
  align-items: flex-start;
  /* รูปชิดบน */
}

.row1 {
  margin-bottom: 4px;
  /* ระยะห่างระหว่างการ์ด */
  height: 160px;
}

.row2 {
  margin-bottom: 4px;
  padding: 12px;
}

.score {
  font-size: 22px;
  font-weight: 700;
  margin-top: 6px;
}

.modifier {
  font-size: 16px;
  color: #444;
  margin-top: 4px;
}

.ability-card {
  margin-right: 8px;
  margin-bottom: 8px;
  width: 120px;
  height: 120px;
  padding: 12px;
  text-align: center;
  border-radius: 12px;
  box-shadow: 0 3px 8px rgba(0, 0, 0, 0.15);
  color: white;
  transition: 0.2s;
  /* สำหรับ hover effect */
}

.ability-card .score {
  font-size: 24px;
  font-weight: bold;
  margin: 6px 0;
}

.ability-card .modifier {
  font-size: 16px;
  color: #f0f0f0;
}

/* สีพื้นหลังแตกต่างตาม ability */
.strength {
  background-color: #ef5350;
}

.dexterity {
  background-color: #42a5f5;
}

.constitution {
  background-color: #66bb6a;
}

.intelligence {
  background-color: #ab47bc;
}

.wisdom {
  background-color: #ffa726;
}

.charisma {
  background-color: #ec407a;
}

.Ash {
  background-color: #90a4ae;
}

.static-card {
  margin-right: 8px;
  margin-bottom: 8px;
  width: 120px;
  height: 120px;
  padding: 12px;
  text-align: center;
  border-radius: 12px;
  box-shadow: 0 3px 8px rgba(0, 0, 0, 0.15);
  color: white;
}

.static-card_HP {
  margin-right: 8px;
  margin-bottom: 8px;
  width: 205px;
  height: 120px;
  padding: 12px;
  text-align: center;
  border-radius: 12px;
  box-shadow: 0 3px 8px rgba(0, 0, 0, 0.15);
  color: white;
}
</style>
