export default (Vue) => {
  Vue.directive('clickOutside', {
    bind: function (el, binding) {
      function documentHandler (e) {
        if (el.contains(e.target)) {
          return false
        }
        if (binding.expression) {
          binding.value(e)
        }
      }
      function keyupEsc(e){
        if (e.key ==="Escape"){
          if (binding.modifiers.esc){
            binding.value(e)
          }
        }
        else{
          return false;
        }
      }
      el._keyupEsc_ = keyupEsc;
      el._vueClickOustside_ = documentHandler
      document.addEventListener('click', documentHandler)
      document.addEventListener('keyup', keyupEsc)
    },
    unbind: function (el) {  //页面跳转触发
      document.removeEventListener('click', el._vueClickOustside_) //不移除， 当组件或元素销毁时，它仍然存在于内存中。
      delete el._vueClickOustside_

      document.removeEventListener('keyup', el._keyupEsc_)
      delete el._keyupEsc_
    }
  })
  Vue.directive('test',{
    bind:function () {
      console.log('test')
    }
  })
}

