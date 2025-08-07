<template>
  <div class="card-container">
    <div class="card" v-for="(card, index) in cards" :key="index">
      <img :src="card.image" alt="Card Image" class="card-image" />
      <h2>{{ card.title }}</h2>
      <p>{{ card.subtitle }}</p>
    </div>

    <div class="button-group">
      <button @click="rotateLeft">⬅️</button>
      <button @click="rotateRight">➡️</button>
    </div>
  </div>
</template>

<script setup>
import { ref } from 'vue';

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
  width: 300px;
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
