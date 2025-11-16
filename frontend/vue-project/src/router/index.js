import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import CharactersView from '../views/CharactersView.vue'
import Alignment_View from '@/views/Alignment_View.vue'
import Charcater_Class_View from '@/views/Charcater_Class_View.vue'
import Character_Race_View from '@/views/Character_Race_View.vue'

const routes = [
  { path: '/', name: 'home', component: HomeView },
  { path: '/characters', name: 'characters', component: CharactersView },
  { path: '/alignments', name: 'alignments', component: Alignment_View },
  { path: '/classes', name: 'classes', component: Charcater_Class_View },
  { path: '/races', name: 'races', component: Character_Race_View },
]

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes,
})

export default router
