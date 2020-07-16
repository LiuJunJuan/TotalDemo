<template>
  <div class="home">
    <img alt="Vue logo" src="../assets/logo.png">
    <HelloWorld msg="Welcome to Your Vue.js App"/>
    <div>
      <input type="checkbox" v-model="checked" value="html" id="html">
      <label for="html">HTM L</label>
      <br>
      <input type="checkbox" v-model="checked" value="js" id="js">
      <label for="js">JavaScript</label>
      <br>
      <input type="checkbox" v-model="checked" value="css" id="css">
      <label for="css">CSS</label>
         <br>
      <p>选择的项是：{{checked}}</p>

    </div>
    <div>
      <input type="checkbox" v-model="toggle" :true-value="value1" :false-value="value2">
          <label>复选框{{toggle}}</label>
    </div>
    <div>
      <input type="text" v-model.lazy="message">
      <p>{{message}}</p>
    </div>
    <div>
      <input type="number" v-model.number="numberMessage">
      <p>{{typeof numberMessage}}</p>
       </div>
    <button @dblclick="count++">双击{{count}} </button>
    <div>

    </div>
  </div>
</template>

<script>
  // @ is an alias to /src
  import HelloWorld from '@/components/HelloWorld.vue'

  export default {
    name: 'Home',
    components: {
      HelloWorld
    },
    data () {
      return {
        count:1,
        checked: [],
        toggle: '',
        value1: 'a',
        value2: 'b',
        message: '',
        numberMessage: null
      }
    },
  }
  function Student(name) {
    this.name = name;
  }
  Student.prototype.study = function () {
    console.log("study js");
  };
</script>
