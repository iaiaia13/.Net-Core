import Vue from 'vue';
import { Component } from 'vue-property-decorator';

@Component({
    components: {
        //MenuComponent: require('../navmenu/navmenu.vue.html')
        LandingPage: require('../LandingPage.vue')
    }
})
export default class AppComponent extends Vue {
}
