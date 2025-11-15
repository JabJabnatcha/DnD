<template>
  <v-container>
    <v-form ref="form" @submit.prevent="submitForm">
      <v-text-field
        v-model="character.name"
        label="Name"
        required
      ></v-text-field>

      <v-text-field
        v-model="character.race"
        label="Race"
      ></v-text-field>

      <v-text-field
        v-model="character.class"
        label="Class"
      ></v-text-field>

      <v-text-field
        v-model.number="character.level"
        label="Level"
        type="number"
      ></v-text-field>

      <v-text-field
        v-model.number="character.strength"
        label="Strength"
        type="number"
      ></v-text-field>

      <v-text-field
        v-model.number="character.dexterity"
        label="Dexterity"
        type="number"
      ></v-text-field>

      <v-text-field
        v-model.number="character.constitution"
        label="Constitution"
        type="number"
      ></v-text-field>

      <v-text-field
        v-model.number="character.intelligence"
        label="Intelligence"
        type="number"
      ></v-text-field>

      <v-text-field
        v-model.number="character.wisdom"
        label="Wisdom"
        type="number"
      ></v-text-field>

      <v-text-field
        v-model.number="character.charisma"
        label="Charisma"
        type="number"
      ></v-text-field>

      <v-btn type="submit" color="primary">{{ isEditMode ? 'Update' : 'Create' }}</v-btn>
      <v-btn @click="cancel" color="secondary">Cancel</v-btn>
    </v-form>
  </v-container>
</template>

<script setup>
import { ref, reactive, onMounted, computed } from 'vue'
import { useRoute, useRouter } from 'vue-router'
import axios from 'axios'

// สำหรับ Create / Edit
const route = useRoute()
const router = useRouter()

const form = ref(null)

const character = reactive({
  id: 0,
  name: '',
  race: '',
  class: '',
  level: 1,
  strength: 10,
  dexterity: 10,
  constitution: 10,
  intelligence: 10,
  wisdom: 10,
  charisma: 10,
  maxHP: 10,
  currentHP: 10,
  maxMP: 5,
  currentMP: 5,
  armorClass: 10,
  initiative: 0,
  speed: 30,
  items: [],
  spells: [],
  isDeleted: false
})

const isEditMode = computed(() => !!route.params.id)

onMounted(async () => {
  if (isEditMode.value) {
    // โหลดข้อมูล character จาก API
    const { data } = await axios.get(`/api/character/${route.params.id}`)
    Object.assign(character, data)
  }
})

const submitForm = async () => {
  try {
    if (isEditMode.value) {
      await axios.put(`/api/character/${character.id}`, character)
    } else {
      await axios.post('/api/character', character)
    }
    router.push('/characters')
  } catch (error) {
    console.error('Error saving character:', error)
  }
}

const cancel = () => {
  router.push('/characters')
}
</script>
