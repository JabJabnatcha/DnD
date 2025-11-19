<template>
  <v-card class="mx-auto pa-4" :elevation="props.cardClass === 'card-center' ? 10 : 5">
    <v-img 
      :src="card.image" 
      class="align-end" 
      cover
      :aspect-ratio="16/9"
    />
    
    <v-card-title class="text-h5 font-weight-bold pt-4">{{ card.title }}</v-card-title>
    
    <v-card-text class="text-subtitle-1">{{ card.subtitle }}</v-card-text>
    
    </v-card>
</template>

<script setup>
import { defineProps } from 'vue';

const props = defineProps({
  // กำหนด props ชื่อ 'card' เพื่อรับข้อมูล Card จาก Parent Component
  card: {
    type: Object,
    required: true,
    default: () => ({ 
        title: 'Default Title', 
        subtitle: 'Default Subtitle', 
        image: '' 
    })
  },
  // รับ prop เพื่อแยกแยะว่า Card ใบนี้คือ Center หรือ Side (เพื่อปรับสไตล์)
  cardClass: {
    type: String,
    default: 'card-side' // 'card-center' หรือ 'card-side'
  }
});
</script>

<style scoped>
/* สไตล์เฉพาะสำหรับ Card Component */
.v-card {
  /* ลบ border และ background ที่กำหนดไว้ในไฟล์หลักออกไป (เพราะจะถูกกำหนดด้วย props ที่ส่งมา) */
  /* กำหนดความกว้างเป็น 100% เพื่อให้ยืดเต็ม v-col ที่ครอบอยู่ */
  width: 100%; 
  text-align: center;
}
</style>