<template>
  <v-app class="bg-image">
    <topbar />

    <div class="layoutCharacters">
      <h1>Characters View</h1>

      <!-- Table -->
      <v-table class="my-table">
        <thead>
          <tr>
            <th>Name</th>
            <th>Player</th>
            <th>Level</th>
            <th>Race</th>
            <th>Sub Race</th>
            <th>Class</th>
            <th>Sub Class</th>
            <th>Actions</th>
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
            <td>
              <v-btn small color="primary" @click="editCharacter(char)">Edit</v-btn>
              <v-btn small color="error" @click="deleteCharacter(char.id)">Delete</v-btn>
            </td>
          </tr>
          <tr v-if="characters.length === 0 && !loading">
            <td :colspan="8" class="text-center">No characters found</td>
          </tr>
        </tbody>
      </v-table>

    </div>
  </v-app>
</template>

<script setup>
import { onMounted, ref } from 'vue';
import axios from 'axios';
import { VApp, VBtn } from 'vuetify/components';

import Topbar from '@/components/Topbar.vue';

const characters = ref([]);
const loading = ref(false);
const error = ref(null);

// ดึงข้อมูล
const getCharacters = async () => {
  loading.value = true;
  try {
    const res = await axios.get('https://localhost:7139/api/Character'); // เปลี่ยน URL เป็น backend ของคุณ
    characters.value = res.data;
  } catch (err) {
    error.value = err.message;
    console.error(err);
  } finally {
    loading.value = false;
  }
};

// ลบ character (Soft delete)
const deleteCharacter = async (id) => {
  try {
    await axios.delete(`https://localhost:7139/api/Character/${id}`);
    getCharacters(); // รีเฟรช table
  } catch (err) {
    console.error(err);
  }
};

// แก้ไข character (สมมติแก้ชื่อ)
const editCharacter = async (char) => {
  try {
    await axios.put(`https://localhost:7139/api/Character/${char.id}`, char);
    getCharacters();
  } catch (err) {
    console.error(err);
  }
};

// เพิ่ม character
const addCharacter = async (newChar) => {
  try {
    await axios.post('https://localhost:7139/api/Character', newChar);
    getCharacters();
  } catch (err) {
    console.error(err);
  }
};

onMounted(() => {
  getCharacters();
});
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
  justify-content: flex-start;
  /* ถ้าอยากให้อยู่ top ให้ใช้ flex-start */
  padding-top: 130px;
  /* เหมือนเดิมสำหรับ topbar */
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