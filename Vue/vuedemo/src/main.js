import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import directives from "./common/Directives"
import './assets/css/common.scss';


Vue.config.productionTip = false
Vue.use(directives)

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
