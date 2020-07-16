export default {
  directives: {
    clickOutside: {
      bind: function (el, binding, vNode) {
        function documentHandler (e) {
          if (el.contains(e.target)) {
            return false
          }
          if (binding.expression) {
            binding.value(e)
          }
        }
        el._vueClickOustside_ = documentHandler();
        document.addEventListener('click',documentHandler);
      },
      unbind:function(el,binding){
        document.removeEventListener('click',el._vueClickOustside_);
        delete el._vueClickOustside_;
      }
    }
  }
}
