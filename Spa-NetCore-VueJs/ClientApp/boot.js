import './css/site.css';
import 'bootstrap';
import Vue from 'vue';
import { router } from "./router/index";

new Vue({
    el: '#app-root',
    router,
    render: h => h(require('./components/app/app.vue'))
});
