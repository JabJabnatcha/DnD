<template>
  <v-container>
    <v-btn color="primary" @click="$router.push('/characters/create')">Create Character</v-btn>
    
    <v-data-table :items="characters" :headers="headers">
      <template v-slot:item.actions="{ item }">
        <v-btn icon @click="editCharacter(item.id)">
          <v-icon>mdi-pencil</v-icon>
        </v-btn>
        <v-btn icon color="red" @click="confirmDelete(item)">
          <v-icon>mdi-delete</v-icon>
        </v-btn>
      </template>
    </v-data-table>

    <delete-dialog v-if="deleteDialog" 
                   :character="selectedCharacter" 
                   @close="deleteDialog=false" 
                   @confirm="deleteCharacter"/>
  </v-container>
</template>

<script>
import characterService from '@/services/characterService';
import DeleteDialog from './DeleteDialog.vue';

export default {
  components: { DeleteDialog },
  data() {
    return {
      characters: [],
      headers: [
        { text: 'Name', value: 'name' },
        { text: 'Class', value: 'class' },
        { text: 'Race', value: 'race' },
        { text: 'Level', value: 'level' },
        { text: 'Actions', value: 'actions', sortable: false },
      ],
      deleteDialog: false,
      selectedCharacter: null,
    };
  },
  mounted() {
    this.fetchCharacters();
  },
  methods: {
    fetchCharacters() {
      characterService.getCharacters().then(res => this.characters = res.data);
    },
    editCharacter(id) {
      this.$router.push(`/characters/edit/${id}`);
    },
    confirmDelete(character) {
      this.selectedCharacter = character;
      this.deleteDialog = true;
    },
    deleteCharacter() {
      characterService.deleteCharacter(this.selectedCharacter.id)
        .then(() => {
          this.fetchCharacters();
          this.deleteDialog = false;
        });
    }
  }
}
</script>
