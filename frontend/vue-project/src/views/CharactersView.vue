<template>
  <v-app class="bg-image">
    <topbar />

    <div class="layoutCharacters">
      <h1>Characters View</h1>

      <!-- Table -->
      <v-data-table :headers="headers" :items="characters" item-value="id" class="my-table">
        <template #item.actions="{ item }">
          <v-btn small color="primary" @click="editCharacter(item)">Edit</v-btn>
          <v-btn small color="error" @click="deleteCharacter(item.id)">Delete</v-btn>
        </template>

        <template #no-data>
          <v-alert type="info" border="left">
            No characters found
          </v-alert>
        </template>
      </v-data-table>


    </div>
  </v-app>
</template>

<script setup>
import { onMounted, ref } from 'vue';
import axios from 'axios';
import { VApp, VBtn,VDataTable,VAlert } from 'vuetify/components';

import Topbar from '@/components/Topbar.vue';

const characters = ref([]);
const loading = ref(false);
const error = ref(null);

const headers = [
  { title: 'Name', value: 'name' },
  { title: 'Player', value: 'player' }, // ถ้าไม่มีใน data จะว่าง
  { title: 'Level', value: 'level' },
  { title: 'Race', value: 'race' },
  { title: 'Sub Race', value: 'subRace' }, // ถ้าไม่มีใน data จะว่าง
  { title: 'Class', value: 'class' },
  { title: 'Sub Class', value: 'subClass' }, // ถ้าไม่มีใน data จะว่าง
  { title: 'Actions', value: 'actions' },
];

// ดึงข้อมูล
//http://localhost:5199/api/Character
const getCharacters = async () => {
  loading.value = true;
  try {
    const res = await axios.get('http://localhost:5199/api/Character');
    console.log(res.data);
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
    await axios.delete(`https://localhost:5199/api/Character/${id}`);
    getCharacters(); // รีเฟรช table
  } catch (err) {
    console.error(err);
  }
};

// แก้ไข character (สมมติแก้ชื่อ)
const editCharacter = async (char) => {
  try {
    await axios.put(`https://localhost:5199/api/Character/${char.id}`, char);
    getCharacters();
  } catch (err) {
    console.error(err);
  }
};

// เพิ่ม character
const addCharacter = async (newChar) => {
  try {
    await axios.post('https://localhost:5199/api/Character', newChar);
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