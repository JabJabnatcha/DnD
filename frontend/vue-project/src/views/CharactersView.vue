<template>
  <v-app class="bg-image">
    <topbar />

    <div class="layoutCharacters">
      <h1>Characters View</h1>
      <!-- ปุ่ม Create -->
      <div class="create-btn-wrapper">
        <v-btn color="success" @click="openCreate">Create Character</v-btn>
      </div>

      <CreateCharacter ref="createComponent" @created="getCharacters" />
      <CharacterEdit ref="editComponent" @updated="getCharacters" />
      <CharacterDelete ref="deleteComponent" @deleted="getCharacters" />


      <!-- Table -->
      <v-data-table :headers="headers" :items="characters" item-value="characterId" class="my-table">
        <template #item.actions="{ item }">
          <v-btn small color="primary" @click="openEdit(item)">Edit</v-btn>
          <v-btn small color="error" @click="openDelete(item)">Delete</v-btn>
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
import { VApp, VBtn, VDataTable, VAlert } from 'vuetify/components';

import Topbar from '@/components/Topbar.vue';

import CreateCharacter from '@/components/CharacterCreate.vue';
import CharacterEdit from '@/components/CharacterEdit.vue';
import CharacterDelete from '@/components/CharacterDelete.vue';

//C:\Users\Laptop-JAB\Desktop\Learn\DnD\frontend\vue-project\src\components\CharacterCreate.vue

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
  { title: '', value: 'actions' },
  { title: 'See More', value: '' },
  
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
const deleteComponent = ref(null);

const openDelete = (char) => {
  if (deleteComponent.value) {
    deleteComponent.value.openDialog(char.id, char.name);
  }
};


const createComponent = ref(null);

const openCreate = () => {
  if (createComponent.value) {
    createComponent.value.openDialog();
  }
};

const editComponent = ref(null);

const openEdit = (char) => {
  console.log("Editing character:", char); // debug
  if (editComponent.value) {
    editComponent.value.openDialog(char);
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

.create-btn-wrapper {
  width: 100%;
  display: flex;
  justify-content: flex-start;
  /* ปุ่มชิดซ้าย */
  margin-bottom: 10px;
  /* เว้นช่องเล็กน้อยก่อน table */
}
</style>