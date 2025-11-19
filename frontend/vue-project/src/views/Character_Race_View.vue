<template>
  <v-app class="bg-image">
    <topbar />

    <div class="layout">
      <transition :name="transitionName" mode="out-in">
        <CardComponent :key="cards[0].title" :card="cards[0]" card-class="card" />
      </transition>

      <v-btn icon @click="rotateLeft" class="nav-button">
        <v-icon size="36">mdi-arrow-left-circle-outline</v-icon>
      </v-btn>

      <transition :name="transitionName" mode="out-in">
        <CardComponent :key="cards[1].title" :card="cards[1]" card-class="card-center" />
      </transition>

      <v-btn icon @click="rotateRight" class="nav-button">
        <v-icon size="36">mdi-arrow-right-circle-outline</v-icon>
      </v-btn>

      <transition :name="transitionName" mode="out-in">
        <CardComponent :key="cards[2].title" :card="cards[2]" card-class="card" />
      </transition>
    </div>

  </v-app>
</template>

<script setup>
import { ref } from 'vue';
import { VApp, VBtn, VIcon } from 'vuetify/components';
import Topbar from '@/components/Topbar.vue';
import CardComponent from '@/components/CardComponent.vue';

const cards = ref([
  { title: 'Card 1', subtitle: 'Subtitle 1', image: new URL('@/assets/TA.jpg', import.meta.url).href },
  { title: 'Card 2', subtitle: 'Subtitle 2', image: new URL('@/assets/Involk.jpg', import.meta.url).href },
  { title: 'Card 3', subtitle: 'Subtitle 3', image: new URL('@/assets/willow.jpg', import.meta.url).href }
]);

// ใช้เก็บ direction ของ animation
const transitionName = ref('slide-right');

const rotateLeft = () => {
  cards.value.unshift(cards.value.pop());
  transitionName.value = 'slide-left';
};
const rotateRight = () => {
  cards.value.push(cards.value.shift());
  transitionName.value = 'slide-right';
};
</script>

<style>
.layout {
  display: flex;
  justify-content: center;
  align-items: center;
  gap: 20px;
  margin-top: 130px;
}

.nav-button {
  background: rgba(255, 255, 255, 0.7);
  border-radius: 50%;
  cursor: pointer;
  transition: background 0.3s;
}

.nav-button:hover {
  background: rgba(255, 255, 255, 0.9);
}

.bg-image {
  min-height: 100vh;
  background-image: url('@/assets/DnD-BG2.jpg');
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
}

/* Slide Right */
.slide-right-enter-active,
.slide-right-leave-active {
  transition: all 0.5s ease;
}

.slide-right-enter-from {
  opacity: 0;
  transform: translateX(50px);
}

.slide-right-leave-to {
  opacity: 0;
  transform: translateX(-50px);
}

/* Slide Left */
.slide-left-enter-active,
.slide-left-leave-active {
  transition: all 0.5s ease;
}

.slide-left-enter-from {
  opacity: 0;
  transform: translateX(-50px);
}

.slide-left-leave-to {
  opacity: 0;
  transform: translateX(50px);
}
</style>
