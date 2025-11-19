<template>
  <div :class="cardClass">
    <img :src="card.image" class="card-image" />
    <h2>{{ card.title }}</h2>
    <p>{{ card.subtitle }}</p>
  </div>
</template>

<script setup>
import { defineProps } from 'vue';

const props = defineProps({
  card: {
    type: Object,
    required: true,
  },
  cardClass: {
    type: String,
    default: 'card', // ใช้ 'card-center' สำหรับ card กลาง
  }
});
</script>

<style scoped>
.card {
  width: 400px;
  margin: 20px;
  border: 1px solid #ccc;
  padding: 16px;
  background: rgba(203, 202, 202, 0.85);
}

.card-center {
  width: 450px;
  margin: 20px;
  border: 1px solid #ccc;
  padding: 16px;
  background: rgba(255,255,255,0.9);
}

.card-image {
  width: 100%;
  height: auto;
}
</style>
