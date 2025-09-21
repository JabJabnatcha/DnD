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
        <v-row class="row1" v-for="character in characters" :key="character.id">
          <v-col cols="12">
            <v-card
              height="150px"
              class="pa-4 character-card"
              color="light-blue lighten-4"
              outlined
            >
              <v-row no-gutters>
                <!-- 1. รูป -->
                <v-col cols="12" sm="2" class="character-img">
                  <v-img
                    :src="character.image"
                    alt="Character Picture"
                    max-width="120"
                    max-height="120"
                  ></v-img>
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
                <div class="modifier">Modifier: {{ abilitiesWithMod[0].mod }}</div>
              </v-card>
              <v-card class="ability-card dexterity" outlined>
                <strong>Dexterity</strong>
                <div class="score">{{ abilitiesWithMod[1].score }}</div>
                <div class="modifier">Modifier: {{ abilitiesWithMod[1].mod }}</div>
              </v-card>
              <v-card class="ability-card constitution" outlined>
                <strong>Constitution</strong>
                <div class="score">{{ abilitiesWithMod[2].score }}</div>
                <div class="modifier">Modifier: {{ abilitiesWithMod[2].mod }}</div>
              </v-card>
              <v-card class="ability-card intelligence" outlined>
                <strong>Intelligence</strong>
                <div class="score">{{ abilitiesWithMod[3].score }}</div>
                <div class="modifier">Modifier: {{ abilitiesWithMod[3].mod }}</div>
              </v-card>
              <v-card class="ability-card wisdom" outlined>
                <strong>Wisdom</strong>
                <div class="score">{{ abilitiesWithMod[4].score }}</div>
                <div class="modifier">Modifier: {{ abilitiesWithMod[4].mod }}</div>
              </v-card>
              <v-card class="ability-card charisma" outlined>
                <strong>Charisma</strong>
                <div class="score">{{ abilitiesWithMod[5].score }}</div>
                <div class="modifier">Modifier: {{ abilitiesWithMod[5].mod }}</div>
              </v-card>
            </v-row>
          </v-col>

          <!-- ด้านขวา: เว้นไว้ -->
          <v-col cols="6">
            <v-card class="pa-4"></v-card>
          </v-col>
        </v-row>

        <!-- Row 3: Example Cards -->
        <v-row class="mb-2">
          <!-- col 1 -->
          <v-col cols="12" md="4">
            <v-card class="pa-4 mt-2" color="pink lighten-4" outlined>
              Row 3, Col 1 – สีอ่อน
            </v-card>
            <v-card class="pa-4 mt-2" color="pink lighten-2" outlined>
              Row 3, Col 1 – สีเข้มขึ้น
            </v-card>
            <v-card class="pa-4 mt-2" color="pink lighten-1" outlined>
              Row 3, Col 1 – สีเข้มสุด
            </v-card>
          </v-col>

          <!-- col 2 -->
          <v-col cols="12" md="4">
            <v-card class="pa-4" color="amber lighten-4" outlined>
              Row 3, Col 2
            </v-card>
          </v-col>

          <!-- col 3 -->
          <v-col cols="12" md="4">
            <v-row>
              <v-col cols="12" sm="4">
                <v-card
                  class="pa-4 mb-2"
                  color="deep-purple lighten-4"
                  outlined
                >
                  Row 3, Col 3 - Card 1
                </v-card>
              </v-col>
              <v-col cols="12" sm="4">
                <v-card
                  class="pa-4 mb-2"
                  color="deep-purple lighten-3"
                  outlined
                >
                  Row 3, Col 3 - Card 2
                </v-card>
              </v-col>
              <v-col cols="12" sm="4">
                <v-card
                  class="pa-4 mb-2"
                  color="deep-purple lighten-2"
                  outlined
                >
                  Row 3, Col 3 - Card 3
                </v-card>
              </v-col>
            </v-row>

            <v-row>
              <v-col cols="12">
                <v-card class="pa-4" color="deep-purple lighten-1" outlined>
                  Row 3, Col 3 - Card ยาวเต็ม Row
                  <br />
                  ข้อความเยอะๆ เพื่อให้เห็นความยาวของ card และ layout
                </v-card>
              </v-col>
            </v-row>
          </v-col>
        </v-row>
      </v-col>

      <!-- ช่องว่างขวา 1/12 -->
      <v-col cols="0.5"></v-col>
    </v-row>
  </div>
</template>

<script setup>
import { ref, computed } from "vue";
import Topbar from "../components/topbar.vue";
import cmImg from "@/assets/cm.jpg";

const characters = ref([
  {
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
  },
]);

// --- ตัวอย่าง abilities (แก้ค่าได้ตามต้องการ) ---
const abilities = ref([
  { name: "Strength", score: 10 },
  { name: "Dexterity", score: 8 },
  { name: "Constitution", score: 7 },
  { name: "Intelligence", score: 19 },
  { name: "Wisdom", score: 20 },
  { name: "Charisma", score: 20 },
]);

// คำนวณ modifier ตาม D&D 5e: floor((score - 10) / 2)
const abilitiesWithMod = computed(() =>
  abilities.value.map((a) => ({
    ...a,
    mod: Math.floor((a.score - 10) / 2),
  }))
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
  text-align: left; /* ชิดซ้าย */
  align-self: flex-start; /* ชิดบน */
}

.character-card .character-img {
  display: flex;
  justify-content: center; /* รูปอยู่กลางแนวนอน */
  align-items: flex-start; /* รูปชิดบน */
}
.row1 {
  margin-bottom: 4px; /* ระยะห่างระหว่างการ์ด */
  height: 160px;
}
.row2{
  margin-bottom: 4px;
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
  padding: 12px;
  text-align: center;
  border-radius: 12px;
  box-shadow: 0 3px 8px rgba(0,0,0,0.15);
  color: white;
  transition: 0.2s; /* สำหรับ hover effect */
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
.strength { background-color: #ef5350; }      /* แดง */
.dexterity { background-color: #42a5f5; }     /* น้ำเงิน */
.constitution { background-color: #66bb6a; }  /* เขียว */
.intelligence { background-color: #ab47bc; }  /* ม่วง */
.wisdom { background-color: #ffa726; }        /* ส้ม */
.charisma { background-color: #ec407a; }      /* ชมพู */

</style>
