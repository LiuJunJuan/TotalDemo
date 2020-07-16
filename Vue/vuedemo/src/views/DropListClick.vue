<template>
  <div v-cloak>
    <div class="main" v-clickoutside="handleColse">
      <button @click ="show=!show"></button>

    </div>
  </div>
</template>

<script>
  export default {
    name: 'DropListClick'
  }
</script>

<style scoped>

</style>
