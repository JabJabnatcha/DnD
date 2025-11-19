// C:\Users\Laptop-JAB\Desktop\Learn\DnD\frontend\vue-project\src\main.js
import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import vuetify from './plugins/vuetify'
import '@mdi/font/css/materialdesignicons.css'

createApp(App)
  .use(router)
  .use(vuetify)
  .mount('#app')
