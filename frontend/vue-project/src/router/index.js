import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import CharactersView from '../views/CharactersView.vue'
import CreateCharacterView from '../views/CreateCharacterView.vue'


const routes = [
  { path: '/', name: 'home', component: HomeView },
  { path: '/characters', name: 'characters', component: CharactersView },
  { path: '/characters/create', name: 'createCharacter', component: CreateCharacterView },
  { path: '/characters/edit/:id', name: 'editCharacter', component: CreateCharacterView },
]

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes,
})

export default router
