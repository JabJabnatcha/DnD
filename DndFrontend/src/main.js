import { createApp } from 'vue'
import './style.css'
import App from './App.vue'
import router from './router'

// ✅ เพิ่มส่วนของ Vuetify
import 'vuetify/styles'
import { createVuetify } from 'vuetify'
import * as components from 'vuetify/components'
import * as directives from 'vuetify/directives'

import '@mdi/font/css/materialdesignicons.css' // ✅ ไอคอน Material Design

// สร้าง instance ของ Vuetify
const vuetify = createVuetify({
  components,
  directives,
  icons: { defaultSet: 'mdi' }, // ✅ ตั้งค่าไอคอนเป็น Material Design Icons
})

const app = createApp(App)
app.use(router)
app.use(vuetify)   // ✅ ใช้ Vuetify ที่นี่
app.mount('#app')
