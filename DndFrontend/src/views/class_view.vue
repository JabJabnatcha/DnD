<template>
  <div><topbar /></div>
  
    <div class="layout">

      <div class="card">
        <img :src="cards[0].image" alt="Card 1" class="card-image" />
        <h2>{{ cards[0].title }}</h2>
        <p>{{ cards[0].subtitle }}</p>
      </div>

    <button @click="rotateLeft" class="nav-button">⬅️</button>

      <div class="card-center">
        <img :src="cards[1].image" alt="Card 2" class="card-image" />
        <h2>{{ cards[1].title }}</h2>
        <p>{{ cards[1].subtitle }}</p>
      </div>

    <button @click="rotateRight" class="nav-button">➡️</button>

      <div class="card">
        <img :src="cards[2].image" alt="Card 3" class="card-image" />
        <h2>{{ cards[2].title }}</h2>
        <p>{{ cards[2].subtitle }}</p>
      </div>
  </div>
</template>

<script setup>
import { ref } from 'vue';
import Topbar from '../components/topbar.vue';

const cards = ref([
  {
    title: 'Card 1',
    subtitle: 'Subtitle 1',
    image: new URL('@/assets/rubic.jpg', import.meta.url).href
  },
  {
    title: 'Card 2',
    subtitle: 'Subtitle 2',
    image: new URL('@/assets/Kenz.jpg', import.meta.url).href
  },
  {
    title: 'Card 3',
    subtitle: 'Subtitle 3',
    image: new URL('@/assets/involk.jpg', import.meta.url).href
  }
]);

function rotateLeft() {
  cards.value.unshift(cards.value.pop());
}

function rotateRight() {
  cards.value.push(cards.value.shift());
}
</script>

<style scoped>
.layout {
  display: flex;
  justify-content: center;
  align-items: center;
  gap: 20px;
  margin-top: 40px;
}

.card-container {
  display: flex;
  flex-direction: column;
  align-items: center;
  color: #ffffff;
}

.card {
  width: 500px;
  margin: 20px;
  border: 1px solid #ccc;
  padding: 16px;
}
.card-center {
  width: 1100px;
  margin: 20px;
  border: 1px solid #ccc;
  padding: 16px;
}

.card-image {
  width: 100%;
  height: auto;
}

.button-group {
  display: flex;
  gap: 10px;
}
</style>
