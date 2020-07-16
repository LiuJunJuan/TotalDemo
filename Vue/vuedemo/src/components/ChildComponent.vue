<template>
  <div class="container">
    <div class="header">
      <slot name="header"></slot>
    </div>
    <div class="main">
      <slot></slot>
    </div>
    <div class="footer ">
      <slot name="footer"></slot>
    </div>
  </div>
</template>

<script>
  export default {
    name: 'ChildComponent'
  }
</script>

<style scoped>

</style>
