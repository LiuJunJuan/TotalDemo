<template>
  <div>
    <h4>Registration Token</h4>
    <p id="token" style="word-break: break-all;">t:{{token}}</p>
    <button class="mdl-button mdl-js-button mdl-button--raised mdl-button--colored">Delete Token</button>
    <div>
      {{message}}
    </div>
  </div>
</template>

<script>
  import firebase from 'firebase/app'
  import('firebase/firebase-app')
  import('firebase/firebase-messaging')
  import 'firebase/auth';
  import 'firebase/firestore'

  export default {
    name: 'Firebase',
    mounted () {
      const messaging = firebase.messaging();
      console.log(messaging);
      this.resetUI(messaging);
      messaging.onMessage((payload) => {
        console.log('Message received. ', payload)
        // Update the UI to include the received message.
        this.appendMessage(payload)
      })
    },
    data () {
      return {
        token: null,
        message:null,
        firebaseConfig: {
          apiKey: 'BEN7ZDw0vQk3WP_6YPkLRMZjJ40sSZUYPLGlA-PkVbu1oiIDgFqG7lDjCbsCGD4upufSEDzu5f0amBrW8lXfM0c',
          authDomain: 'PROJECT_ID.firebaseapp.com',
          databaseURL: 'https://PROJECT_ID.firebaseio.com',
          projectId: 'PROJECT_ID',
          storageBucket: 'PROJECT_ID.appspot.com',
          messagingSenderId: 'SENDER_ID',
          appId: 'APP_ID',
          measurementId: 'G-MEASUREMENT_ID',
        }
      }
    },
    methods: {
      resetUI (messaging) {
        this.showToken('loading...')
        // Get registration token. Initially this makes a network call, once retrieved
        // subsequent calls to getToken will return from cache.
        messaging.getToken({ vapidKey: 'BEN7ZDw0vQk3WP_6YPkLRMZjJ40sSZUYPLGlA-PkVbu1oiIDgFqG7lDjCbsCGD4upufSEDzu5f0amBrW8lXfM0c' }).then((currentToken) => {
          if (currentToken) {
            console.log(currentToken);
            this.showToken(currentToken);
          } else {
            // Show permission request.
            console.log('No registration token available. Request permission to generate one.')
            // Show permission UI.
          }
        }).catch((err) => {
          console.log('An error occurred while retrieving token. ', err)
          this.showToken('Error retrieving registration token. ', err)
        })
      },
      showToken(token){
        this.token = token;
      },
      appendMessage (payload) {
        const messagesElement = document.querySelector('#messages')
        const dataHeaderElement = document.createElement('h5')
        const dataElement = document.createElement('pre')
        dataElement.style = 'overflow-x:hidden;'
        dataHeaderElement.textContent = 'Received message:'
        dataElement.textContent = JSON.stringify(payload, null, 2)
        messagesElement.appendChild(dataHeaderElement)
        messagesElement.appendChild(dataElement)
      }
    }
  }
</script>

<style scoped>

</style>
