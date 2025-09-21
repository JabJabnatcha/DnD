<template>
  <v-container fluid>
    <v-row>
      <!-- left spacing 1 column -->
      <v-col cols="1" />

      <!-- main container ครอบ 10 columns -->
      <v-col cols="10">
        <v-data-table
          :headers="headers"
          :items="characters"
          class="elevation-2"
          fixed-header
          height="400px"
          hover
          density="comfortable"
        >
          <!-- Toolbar ด้านบน -->
          <template v-slot:top>
            <v-toolbar flat>
              <v-toolbar-title class="font-weight-bold">Characters</v-toolbar-title>
              <v-spacer></v-spacer>
              <v-btn color="primary" @click="addCharacter" prepend-icon="mdi-plus">
                เพิ่มตัวละคร
              </v-btn>
            </v-toolbar>
          </template>

          <!-- ปุ่มในคอลัมน์ Actions -->
          <template v-slot:item.actions="{ item }">
            <div class="text-center">
              <v-btn icon color="dark-gray" @click="goToSheet(item)" title="See More">
                <v-icon>mdi-eye</v-icon>
              </v-btn>
              <v-btn icon color="blue" @click="editCharacter(item)" title="Edit">
                <v-icon>mdi-pencil</v-icon>
              </v-btn>
              <v-btn icon color="red" @click="deleteCharacter(item)" title="Delete">
                <v-icon>mdi-delete</v-icon>
              </v-btn>
            </div>
          </template>
        </v-data-table>
      </v-col>

      <!-- right spacing 1 column -->
      <v-col cols="1" />
    </v-row>
  </v-container>
</template>


<script>
export default {
  name: "CharacterTable",
  data() {
    return {
      headers: [
        { title: "Player", value: "player", align: "center", class: "text-center" },
        { title: "Name", value: "name", align: "center", class: "text-center" },
        { title: "Race", value: "race", align: "center", class: "text-center" },
        { title: "Class", value: "class", align: "center", class: "text-center" },
        { title: "Level", value: "level", align: "center", class: "text-center" },
        { title: "Alignment", value: "alignment", align: "center", class: "text-center" },
        { title: "Actions", value: "actions", sortable: false, align: "center", class: "text-center" },
      ],
      characters: [
        { id: 1, player: "John", name: "Aragon", race: "Human", class: "Fighter", level: 5, alignment: "Neutral Good" },
        { id: 2, player: "Jane", name: "Lyra", race: "Elf", class: "Wizard", level: 7, alignment: "Chaotic Good" },
        { id: 3, player: "Mike", name: "Thorn", race: "Dwarf", class: "Cleric", level: 4, alignment: "Lawful Good" },
      ],
    };
  },
  methods: {
    addCharacter() {
      console.log("Add character clicked");
    },
    goToSheet(item) {
      this.$router.push({ name: 'CharacterSheet', params: { id: item.id } });
    },
    editCharacter(item) {
      console.log("Edit", item);
    },
    deleteCharacter(item) {
      console.log("Delete", item);
    },
  },
};
</script>


<style scoped>
.v-data-table-header th {
  background-color: #f0f4ff;
  /* สีพื้นหลังหัวตาราง */
  font-weight: bold;
  font-size: 14px;
  display: flex;
  justify-content: center;
  /* ทำให้ข้อความอยู่กลาง */
  align-items: center;
}

.v-data-table td {
  text-align: center;
  /* จัด cell ทั้งหมดตรงกลาง */
}
</style>
