import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home,
    meta: {
      title: 'Demo'
    }
  },
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  },
  {
    path: '/htmlDemo',
    name: 'htmlDemo',
    component: () => import('../views/HtmlTest')
  },
  {
    path: '/dropList',
    name: 'dropList',
    component: () => import('../views/DropListClick'),
    meta: {
      title: 'DropList'
    }
  },
  {
    path: '/firebase',
    name: 'firebase',
    component: () => import('../views/Firebase'),
    meta: {
      title: 'Firebase'
    }
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})
router.beforeEach((to, from, next) => {
  if (to.meta.title) {
    document.title = to.meta.title
  }
  next();
})

export default router
