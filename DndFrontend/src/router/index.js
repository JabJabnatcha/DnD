import { createRouter, createWebHistory } from "vue-router";
import MainView from "../views/main_view.vue";
import CharacterView from "../views/character_view.vue";
import RaceView from "../views/race_view.vue";
import ClassView from "../views/class_view.vue";
import AlignmentView from "../views/alignment_view.vue";
import CharacterSheetView from "../views/character_sheet_view.vue";

const routes = [
  { path: "/", name: "Main", component: MainView },
  { path: "/races", name: "Races", component: RaceView },
  { path: "/classes", name: "Classes", component: ClassView },
  { path: "/alignments", name: "Alignments", component: AlignmentView },
  { path: "/characters", name: "Characters", component: CharacterView },

  // หน้า sheet ของตัวละคร
  {
    path: "/character_sheet/:id",
    name: "CharacterSheet",
    component: CharacterSheetView,
    props: true,
  },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router;