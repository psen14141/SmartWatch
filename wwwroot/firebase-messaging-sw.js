// Import and configure the Firebase SDK
// These scripts are made available when the app is served or deployed on Firebase Hosting
// If you do not serve/host your project using Firebase Hosting see https://firebase.google.com/docs/web/setup
/*importScripts('/__/firebase/8.6.8/firebase-app.js');
importScripts('/__/firebase/8.6.8/firebase-messaging.js');
importScripts('/__/firebase/init.js');

const messaging = firebase.messaging();
*/


 // Give the service worker access to Firebase Messaging.
 // Note that you can only use Firebase Messaging here. Other Firebase libraries
 // are not available in the service worker.
 importScripts('https://www.gstatic.com/firebasejs/8.6.8/firebase-app.js');
 importScripts('https://www.gstatic.com/firebasejs/8.6.8/firebase-messaging.js');

 // Initialize the Firebase app in the service worker by passing in
 // your app's Firebase config object.
 // https://firebase.google.com/docs/web/setup#config-object

firebase.initializeApp({
    apiKey: "AIzaSyCKW-AIzaSyCEiGAEmL5NGEKWW5XtA84WwZSOQjNoGVk",
    authDomain: "daiki-72136.firebaseapp.com",
    projectId: "daiki-72136",
    storageBucket: "daiki-72136.appspot.com",
    messagingSenderId: "4299973077",
    appId: "1:4299973077:web:8a7d85de05c4d7320f9d5c",
    measurementId: "G-DG0V20YVC3"
});

 // Retrieve an instance of Firebase Messaging so that it can handle background
 // messages.
 const messaging = firebase.messaging();
 


// If you would like to customize notifications that are received in the
// background (Web app is closed or not in browser focus) then you should
// implement this optional method.
// Keep in mind that FCM will still show notification messages automatically 
// and you should use data messages for custom notifications.
// For more info see: 
// https://firebase.google.com/docs/cloud-messaging/concept-options
messaging.onBackgroundMessage((payload) => {
    console.log('[firebase-messaging-sw.js] Received background message ', payload);
    // Customize notification here
    const notificationTitle = 'Background Message Title';
    const notificationOptions = {
        body: 'Background Message body.',
        icon: '/firebase-logo.png'
    };

    self.registration.showNotification(notificationTitle,
        notificationOptions);
});
