<template>
    <div id="app" class="wrapper">
        <!-- <div class="row">
            <div class="col-sm-3">
                <nav-menu params="route: route"></nav-menu>
            </div>
            <div class="col-sm-9">
                <router-view></router-view>
            </div>
        </div> -->
        <header class="topnavbar-wrapper">
            <ide-app-bar/>
         </header>

        <aside  class="aside">
            <ide-left-side-panel/>
        </aside>

        <aside class="offsidebar hide">
            <ide-right-side-panel/>
         </aside>

        <section>
            <router-view></router-view>
        </section>

        <footer>
            <ide-app-footer/>
        </footer>
    </div>

</template>

<script>
import Vue from "vue";
import CounterExample from "./counter-example";
import FetchData from "./fetch-data";
import HomePage from "./home-page";
import NavMenu from "./nav-menu";

import AppBar from "./ide/app-bar.vue";
import LeftSidePanel from "./ide/app-left-side-panel.vue";
import RightSidePanel from "./ide/app-right-side-panel.vue";
import AppFooter from "./ide/app-footer.vue";

import ProductNew from 'components/views/product-new'
import ProductList from 'components/views/product-list'
import ProductSettings from 'components/views/product-settings'

Vue.component("counter-example", CounterExample);
Vue.component("fetch-data", FetchData);
Vue.component("home-page", HomePage);
Vue.component("nav-menu", NavMenu);

Vue.component("ide-app-bar", AppBar);
Vue.component("ide-left-side-panel", LeftSidePanel);
Vue.component("ide-right-side-panel", RightSidePanel);
Vue.component("ide-app-footer", AppFooter);


export default {
  data() {
    return {};
  }
};
</script>

<style>

</style>
