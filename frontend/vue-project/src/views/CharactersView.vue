<template>
  <v-app class="bg-image">
    <topbar />

    <div class="layoutCharacters">
      <h1>Characters View</h1>

      <!-- Table -->
      <v-simple-table class="my-table">
        <thead>
          <tr>
            <th>Name</th>
            <th>Player</th>
            <th>Level</th>
            <th>Race</th>
            <th>Sub Race</th>
            <th>Class</th>
            <th>Sub Class</th>

          </tr>
        </thead>
        <tbody>
          <tr v-for="char in characters" :key="char.id">
            <td>{{ char.name }}</td>
            <td>{{ char.player }}</td>
            <td>{{ char.level }}</td>
            <td>{{ char.race }}</td>
            <td>{{ char.subRace }}</td>
            <td>{{ char.class }}</td>
            <td>{{ char.subClass }}</td>

          </tr>
          <tr v-if="characters.length === 0">
            <td :colspan="7" class="text-center">No characters found</td>
          </tr>
        </tbody>
      </v-simple-table>
    </div>
  </v-app>
</template>

<script setup>
import { ref } from 'vue';
import Topbar from '@/components/Topbar.vue';

const characters = ref([
  { id: 1, name: 'Arthas', player: 'John', level: 5, race: 'Human', subRace: 'None', class: 'Paladin', subClass: 'Vengeance' },
  { id: 2, name: 'Illidan', player: 'Mike', level: 7, race: 'Night Elf', subRace: 'Demon Hunter', class: 'Rogue', subClass: 'Assassin' },
  { id: 3, name: 'Legolus', player: 'Jame', level: 5, race: 'Human', subRace: 'None', class: 'Paladin', subClass: 'Vengeance' },
  { id: 4, name: 'Aragon', player: 'sara', level: 7, race: 'Night Elf', subRace: 'Demon Hunter', class: 'Rogue', subClass: 'Assassin' }
]);
</script>

<style>
/* BG ครอบ v-app เต็ม viewport */
.bg-image {
  min-height: 100vh;
  width: 100%;
  background-image: url('@/assets/DnD-BG2.jpg');
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;

  /* ใช้ flex เพื่อให้ content อยู่กลางจอแนวตั้ง */
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: flex-start; /* ถ้าอยากให้อยู่ top ให้ใช้ flex-start */
  padding-top: 130px; /* เหมือนเดิมสำหรับ topbar */
  box-sizing: border-box;
}

.layoutCharacters {
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 20px;
  box-sizing: border-box;
  margin: 0 auto;
}

.my-table {
  width: 100%;
  background-color: #ffffff;
  border-radius: 8px;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
  overflow: hidden;
  box-sizing: border-box;
}
.my-table thead {
  background-color: #bdbdbd;
}

.my-table th,
.my-table td {
  padding: 8px;
  border-bottom: 1px solid #606060;
  text-align: left;
}
</style>