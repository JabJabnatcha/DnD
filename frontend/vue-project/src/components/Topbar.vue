<!-- src/components/topbar.vue -->
<template>
  <header class="top-bar">
    <nav>
      <router-link class="nav-btn" to="/">Home</router-link>
      <router-link class="nav-btn" to="/characters">Characters</router-link>
      <router-link class="nav-btn" to="/races">Races</router-link>
      <router-link class="nav-btn" to="/classes">Classes</router-link>
      <router-link class="nav-btn" to="/alignments">Alignments</router-link>
    </nav>
  </header>
</template>

<script setup>
</script>

<style scoped>
.top-bar {
  background-color: #3333332b;
  color: white;
  padding: 2rem;
  text-align: center;
  position: fixed; 
  top: 0;
  left: 0;
  width: 100%;      
  z-index: 1000;    
}
nav {
  display: flex;
  justify-content: center;
  gap: 2rem;
}
a {
  color: white;
  text-decoration: none;
}
a.router-link-exact-active {
  font-weight: bold;
  text-decoration: underline;
}


.nav-btn {
  background-color: #2d3944;
  color: white;
  text-decoration: none;
  padding: 0.8rem 1.5rem;
  border-radius: 8px;
  font-size: 2rem;
  font-family: 'Arial', sans-serif;
  font-weight: bold;
  text-transform: uppercase;
  transition: background-color 0.3s ease, transform 0.2s ease;
}

/* เพิ่ม padding และสไตล์ปุ่มให้ทุกลิงก์ */
nav a {
  color: white;
  text-decoration: none;
  padding: 0.5rem 1rem;
  border-radius: 5px;
  transition: background-color 0.3s ease;
}

nav a:hover {
  opacity: 0.8;
}

</style>