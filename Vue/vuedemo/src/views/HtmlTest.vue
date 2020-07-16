<template>
  <div>
    <div>Test</div>
    <childComponent>
      <template v-slot:header>
        <h1>Here might be a page title</h1>
      </template>
      <p>A paragraph for the main content.</p>
      <p>And another one.</p>
      <template v-slot:footer>
        <p>Here's some contact info</p>
      </template>
    </childComponent>
    <div>
      <div id="div" v-if="showDiv">这是一段文本</div>
      <button @click="getText">获取div内容</button>
    </div>
    <div>
      <input type="text" v-focus>
    </div>
    <div v-test:msg.a.b="message"></div>
  </div>
</template>

<script>
  import childComponent from '../components/ChildComponent'

  export default {
    name: 'HtmlTest',
    components: {
      childComponent
    },
    directives: {
      focus: {
        inserted: function (el) {
          el.focus()
        }
      },
      test: {
        bind: function (el, binding, vnode) {
          let keys = []
          for (let i in vnode) {
            keys.push(i)
          }
          el.innerHTML =
            'name:' + binding.name + '<br>' +
            'value:' + binding.value + '<br>' +
            'expression:' + binding.expression + '<br>' +
            'arg:' + binding.arg + '<br>' +
            'modifiers:' + JSON.stringify(binding.modifiers) + '<br>' +
            'vnode keys:' + keys.join(',') + '<br>'
        }
      }
    },
    data () {
      return {
        showDiv: false,
        message: 'some text'
      }
    },
    methods: {
      getText: function () {
        this.showDiv = true
        this.$nextTick(() => {
          let text = document.getElementById('div').innerHTML
          console.log(text)
        })
      }
    }
  }
</script>

<style scoped>
</style>
