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

      function keyupEsc (e) {
        if (e.key === 'Escape') {
          if (binding.modifiers.esc) {
            binding.value(e)
          }
        } else {
          return false
        }
      }

      el._keyupEsc_ = keyupEsc
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

  Vue.directive('reset', {
    update: function (el, binding) {
      console.log(el)
      console.log(binding.oldValue)
    }
  })

  Vue.directive('focus',{
    inserted: function (el) {
      el.focus()
    }
  })

  Vue.directive('time', {
    bind: function (el, binding) {
      el.innerHTML = Time.getFormatTime(binding.value)
      el._timeout_ = setInterval(function () {
        el.innerHTML = Time.getFormatTime(binding.value)
      }, 60000)
    },
    unbind: function (el) {
      clearInterval(el._timeout_)
      delete el._timeout_
    }
  })

  let Time = {
    //获取当前时间戳
    getUnix: function () {
      let date = new Date()
      return date.getTime()
    },
    //获取今天0 点0 分0 秒的时间戳
    getTodayUnix: function () {
      let date = new Date()
      date.setHours(0)
      date.setMinutes(0)
      date.setSeconds(0)
      date.setMilliseconds(0)
      return date.getTime()
    },
//获取今年1 月1 日0 点0 分0 秒的时间戳
    getYearUnix: function () {
      let date = new Date()
      date.setMonth(0)
      date.setDate(1)
      date.setHours(0)
      date.setMinutes(0)
      date.setSeconds(0)
      date.setMilliseconds(0)
      return date.getTime()
    },
//获取标准年月日
    getLastDate: function (time) {
      let date = new Date(time)
      let month = date.getMonth() + 1 < 10 ? '0' + (date.getMonth() + 1) : date.getMonth() + 1
      let day = date.getDate() < 10 ? '0' + date.getDate() : date.getDate()
      return date.getFullYear() + '-' + month + '-' + day
    },
//转换时间
    getFormatTime: function (timestamp) {
      let now = this.getUnix() //当前时间戳
      let today = this.getTodayUnix() //今天0 点时间戳
      let year = this.getYearUnix() //今年0 点时间戳
      let timer = (now - timestamp) / 1000 //转换为秒级时间戳
      let tip = ''
      if (timer <= 0) {
        tip = '刚刚'
      } else if (Math.floor(timer / 60) <= 0) {
        tip = '刚刚'
      } else if (timer < 3600) {
        tip = Math.floor(timer / 60) + '分钟前'
      } else if (timer >= 3600 && (timestamp - today >= 0)) {
        tip = Math.floor(timer / 3600) + '小时前'
      } else if (timer / 86400 <= 31) {
        tip = Math.ceil(timer / 86400) + '天前'
      } else {
        tip = this.getLastDate(timestamp)
      }
      return tip
    }
  }
}

