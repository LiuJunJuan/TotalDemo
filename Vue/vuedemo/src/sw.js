import('firebase/firebase-app')
import('firebase/firebase-messaging')
import firebase from 'firebase/app'


const messaging = firebase.messaging();
messaging.onBackgroundMessage(function(payload) {
  console.log('[sw.js] Received background message ', payload);
  // Customize notification here
  const notificationTitle = 'Background Message Title';
  const notificationOptions = {
    body: 'Background Message body.',
    icon: '/firebase-logo.png'
  };
  self.registration.showNotification(notificationTitle,
    notificationOptions);
});


