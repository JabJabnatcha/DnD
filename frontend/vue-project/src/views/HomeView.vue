
<template>
  <v-app class="bg-image">
      <topbar />

      <div class="layout">
        <div class="card">
          <img :src="cards[0].image" class="card-image" />
          <h2>{{ cards[0].title }}</h2>
          <p>{{ cards[0].subtitle }}</p>
        </div>

        <button @click="rotateLeft" class="nav-button">⬅️</button>

        <div class="card-center">
          <img :src="cards[1].image" class="card-image" />
          <h2>{{ cards[1].title }}</h2>
          <p>{{ cards[1].subtitle }}</p>
        </div>

        <button @click="rotateRight" class="nav-button">➡️</button>

        <div class="card">
          <img :src="cards[2].image" class="card-image" />
          <h2>{{ cards[2].title }}</h2>
          <p>{{ cards[2].subtitle }}</p>
        </div>
      </div>
  </v-app>
</template>

<script setup>
import { ref } from 'vue';
import Topbar from '@/components/Topbar.vue';
import { VApp } from 'vuetify/components';

const cards = ref([
  {
    title: 'Card 1',
    subtitle: 'Subtitle 1',
    image: new URL('@/assets/cm.jpg', import.meta.url).href
  },
  {
    title: 'Card 2',
    subtitle: 'Subtitle 2',
    image: new URL('@/assets/drown.jpg', import.meta.url).href
  },
  {
    title: 'Card 3',
    subtitle: 'Subtitle 3',
    image: new URL('@/assets/lina.jpg', import.meta.url).href
  }
]);

const rotateLeft = () => {
  cards.value.unshift(cards.value.pop());
};
const rotateRight = () => {
  cards.value.push(cards.value.shift());
};
</script>

<style>
/*import bg_homeview from '@/assets/DnD-BG.jpg'; */
.bg-image {
  min-height: 100vh;
  background-image: url('@/assets/DnD-BG2.jpg');
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
}

.layout {
  display: flex;
  justify-content: center;
  align-items: center;
  gap: 20px;
  margin-top: 130px;
}

.card {
  width: 500px;
  border: 1px solid #ccc;
  padding: 16px;
  background: rgba(255,255,255,0.85);
}

.card-center {
  width: 600px;
  border: 1px solid #ccc;
  padding: 16px;
  background: rgba(255,255,255,0.9);
}

.card-image {
  width: 100%;
}
</style>
