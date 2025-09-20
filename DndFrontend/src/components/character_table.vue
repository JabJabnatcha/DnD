<!-- src/components/character_table.vue -->
<template>
  <v-data-table
    :headers="headers"
    :items="characters"
    item-value="id"
    class="elevation-1 with-borders"
    dense
    :items-per-page="5"
  >
    <template #item.actions="{ item }">
      <v-btn small color="primary" @click.stop="goToSheet(item.id)">See More</v-btn>
      <v-btn small color="warning" @click.stop="editCharacter(item.id)">Edit</v-btn>
      <v-btn small color="error" @click.stop="deleteCharacter(item.id)">Delete</v-btn>
    </template>
  </v-data-table>
</template>

<script setup>
import { useRouter } from 'vue-router';
const router = useRouter();

defineProps(['characters']);

const headers = [
  { title: 'Player', value: 'player' },
  { title: 'Name', value: 'name' },
  { title: 'Race', value: 'race' },
  { title: 'Class', value: 'class' },
  { title: 'Level', value: 'level' },
  { title: 'Alignment', value: 'alignment' },
  { title: 'Actions', value: 'actions', sortable: false },
];

const goToSheet = (id) => {
  router.push(`/character_sheet/${id}`);
};

const editCharacter = (id) => {
  console.log('Edit', id);
};

const deleteCharacter = (id) => {
  console.log('Delete', id);
};
</script>

<style scoped>
.with-borders {
  width: 80%;
  margin: 2rem auto;
  border: 1px solid var(--v-border-color);
}

/* กำหนดเส้นของ cell */
.with-borders .v-data-table__td,
.with-borders .v-data-table__th {
  border-left: 1px solid var(--v-border-color);
  border-right: 1px solid var(--v-border-color);
  text-align: center; /* จัดกึ่งกลางข้อความ */
}

/* สไตล์หัวตาราง */
.with-borders .v-data-table__th {
  background-color: black;
  color: white;
  font-weight: bold;
  text-align: center;
}
</style>
