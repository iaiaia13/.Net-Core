import './css/site.css';
import 'bootstrap';
import Vue from 'vue';
import router from './router';

new Vue({
    el: '#app-root',
    router,
    render: h => h(require('./components/app/app.vue'))
});
