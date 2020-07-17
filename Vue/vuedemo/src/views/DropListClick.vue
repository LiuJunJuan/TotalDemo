<template>
  <div v-cloak>
    <div class="main" v-clickOutside.esc="handleClose" style="width: 200px"> <!--@keyup.esc="handleClose"-->
      <button @click="show=!show">点击显示下拉菜单</button>
      <div class="dropdown" v-show="show">
        <p>下拉内容，点击外部区域关闭</p>
      </div>
    </div>
  </div>
</template>

<script>
  export default {
    name: 'DropListClick',
    data () {
      return {
        show: false,
        esc: false
      }
    },
    directives: [],
    methods: {
      handleClose: function () {
        this.show = false
      }
    }
  }
</script>

<style scoped>
  [v-cloak] {
    display: none;
  }

  . main {
    width: 125px;
  }

  button {
    display: block;
    width: 100px;
    color: #fff;
    background-color: #39f;
    border: 0;
    padding: 6px;
    text-align: center;
    font-size: 12px;
    border-radius: 4px;
    cursor: pointer;
    outline: none;
    position: relative;
  }

  button :active {
    top: 1px;
    left: 1px;
  }

  .dropdown {
    width: 100px;
    height: 150px;
    margin: 5px 0;
    font-size: 12px;
    background-color: #fff;
    border-radius: 4px;
    box-shadow: 0 1px 6px rgba(0, 0, 0, .2);
  }

  .dropdown p {
    display: inline-block;
    padding: 6px;
  }

</style>
