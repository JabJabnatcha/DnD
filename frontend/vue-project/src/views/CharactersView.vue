<template>
  <v-container>
    <v-btn color="primary" class="mb-4" @click="createCharacter">Create Character</v-btn>

    <v-data-table
      :headers="headers"
      :items="characters"
      item-key="id"
    >
      <template v-slot:item.actions="{ item }">
        <v-btn icon color="blue" @click="editCharacter(item.id)">
          <v-icon>mdi-pencil</v-icon>
        </v-btn>
        <v-btn icon color="red" @click="confirmDelete(item)">
          <v-icon>mdi-delete</v-icon>
        </v-btn>
      </template>
    </v-data-table>

    <!-- Delete Confirmation Dialog -->
    <v-dialog v-model="deleteDialog" max-width="400">
      <v-card>
        <v-card-title class="headline">Confirm Delete</v-card-title>
        <v-card-text>Are you sure you want to delete {{ selectedCharacter?.name }}?</v-card-text>
        <v-card-actions>
          <v-btn color="secondary" text @click="deleteDialog = false">Cancel</v-btn>
          <v-btn color="red" text @click="deleteCharacter">Delete</v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
  </v-container>
</template>

<script setup>
import { ref, onMounted } from 'vue'
import { useRouter } from 'vue-router'
import axios from 'axios'

const router = useRouter()
const characters = ref([])
const deleteDialog = ref(false)
const selectedCharacter = ref(null)

const headers = [
  { text: 'Name', value: 'name' },
  { text: 'Class', value: 'class' },
  { text: 'Level', value: 'level' },
  { text: 'Actions', value: 'actions', sortable: false }
]

const loadCharacters = async () => {
  const { data } = await axios.get('/api/character')
  characters.value = data
}

onMounted(loadCharacters)

const createCharacter = () => {
  router.push('/characters/create')
}

const editCharacter = (id) => {
  router.push(`/characters/edit/${id}`)
}

const confirmDelete = (character) => {
  selectedCharacter.value = character
  deleteDialog.value = true
}

const deleteCharacter = async () => {
  await axios.delete(`/api/character/${selectedCharacter.value.id}`)
  deleteDialog.value = false
  loadCharacters()
}
</script>
