<template>
  <div class="about">
    <h1>This is an about page {{count}}</h1>
    <div>
      <button @click="add">add</button>
    </div>
  </div>
</template>

<script>
  import { ref,isRef, computed, watch } from 'vue'
  export default {

    setup () {
      const count = ref(0);
      const add = () => {
        count.value++
        isRef(count);
      }
      return {
        count,
        add
      }
    }
  }
</script>
