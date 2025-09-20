import { createApp } from 'vue'
import './style.css'
import App from './App.vue'
import router from './router'

// ✅ เพิ่มส่วนของ Vuetify
import 'vuetify/styles'
import { createVuetify } from 'vuetify'
import * as components from 'vuetify/components'
import * as directives from 'vuetify/directives'

// สร้าง instance ของ Vuetify
const vuetify = createVuetify({
  components,
  directives,
})

const app = createApp(App)
app.use(router)
app.use(vuetify)   // ✅ ใช้ Vuetify ที่นี่
app.mount('#app')
