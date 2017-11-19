<template >
    <!-- START Sidebar (left)-->
    <div id="leftSidePanel" class="aside-inner">
        <nav data-sidebar-anyclick-close="" class="sidebar">
            <!-- START sidebar nav-->
            <ul class="nav">
                <!-- START user info-->
                <li class="has-user-block">
                    <div id="user-block" class="collapse">
                        <div class="item user-block">
                            <!-- User picture-->
                            <div class="user-block-picture">
                                <div class="user-block-status">
                                    <img src="img/user/02.jpg" alt="Avatar" width="60" height="60" class="img-thumbnail img-circle">
                                    <div class="circle circle-success circle-lg"></div>
                                </div>
                            </div>
                            <!-- Name and Job-->
                            <div class="user-block-info">
                                <span class="user-block-name">Hello, Mike</span>
                                <span class="user-block-role">Designer</span>
                            </div>
                        </div>
                    </div>
                </li>
                <!-- END user info-->
                <!-- Iterates over all sidebar items-->
                <li class="nav-heading ">
                    <span data-localize="sidebar.heading.HEADER">Main Navigation</span>
                </li>

                <li class="nav-heading ">
                    <span data-localize="sidebar.heading.MAIN"></span>
                </li>


                <li class=" ">
                    <a href="#dashboard" title="Dashboard" data-toggle="collapse">
                        <div class="pull-right label label-info">3</div>
                        <em class="icon-speedometer"></em>
                        <span data-localize="sidebar.nav.DASHBOARD">Dashboards</span>
                    </a>
                    <ul id="dashboard" class="nav sidebar-subnav collapse">
                        <li class="sidebar-subnav-header">Dashboard</li>
                        <li class=" active">
                            <a href="dashboard.html" title="Dashboard v1">
                                <span>Dashboard v1</span>
                            </a>
                        </li>
                        <li class=" ">
                            <a href="dashboard_v2.html" title="Dashboard v2">
                                <span>Dashboard v2</span>
                            </a>
                        </li>
                        <li class=" ">
                            <a href="dashboard_v3.html" title="Dashboard v3">
                                <span>Dashboard v3</span>
                            </a>
                        </li>
                    </ul>
                </li>

                <!-- ============================PRODUCTS======================== -->
                <li class="nav-heading ">
                    <span data-localize="sidebar.heading.PRODUCTS">Products</span>
                </li>
                <navi-group-control v-bind:itemsSource="productsMenu.items"
                    header="{text:'Products', number:3, icon:'icon-speedometer'}"
                    headerText="Products" headerIcon="icon-speedometer" headerNumber="3"
                    headerLink="#products"  headerLocalizationPath="sidebar.nav.PRODUCTS.Header"/>

                        <!-- <em class="icon-grid"></em>
                        <em class="icon-layers"></em>
                        <em class="icon-chemistry"></em>
                        <em class="icon-note"></em>
                        <em class="icon-graph"></em>
                        <em class="icon-grid"></em>
                        <em class="icon-map"></em>
                        <em class="icon-doc"></em>
                        <em class="icon-cup"></em>
                        <em class="fa fa-folder-open-o"></em>
                 -->
                <!-- ========================== -->
                 <li class="nav-heading ">
                    <span data-localize="sidebar.heading.Docs">Documentation</span>
                </li>
                <navi-group-control v-bind:itemsSource="documentationsMenu.items"
                    headerText="Documentation" headerIcon="icon-graduation"
                    headerNumber="3" headerLink="#docs" headerLocalizationPath="sidebar.nav.DOCUMENTATION.Header"/>

                        <!--
                        <em class="icon-grid"></em>
                        <em class="icon-layers"></em>
                        <em class="icon-chemistry"></em>
                        <em class="icon-note"></em>
                        <em class="icon-graph"></em>
                        <em class="icon-grid"></em>
                        <em class="icon-map"></em>
                        <em class="icon-doc"></em>
                        <em class="icon-cup"></em>
                        <em class="fa fa-folder-open-o"></em>
                        <em class="icon-graduation"></em>
                 -->
            </ul>
            <!-- END sidebar nav-->
        </nav>
    </div>
    <!-- END Sidebar (left)-->
</template>

<script>
import ProductNaviComponent from "components/ide/navi-group-control";
// import Vue from "vue";
// Vue.component( {'product-navi-component': ProductNaviComponent});

export default {
  name: "leftSidePanel",
  components: { "navi-group-control": ProductNaviComponent },
  created() {
    this.productsMenu = {header:{},items:[
      { title: "List", link: "/product/index",   localizationPath:"sidebar.nav.PRODUCTS.List", icon:"icon-speedometer" },
      { title: "New", link: "/product/new", number:2, numberClass:'label-info', localizationPath:"sidebar.nav.PRODUCTS.New" },
      { title: "Settings", link: "/product/settings", number:1, numberClass:'label-success' , localizationPath:"sidebar.nav.PRODUCTS.Settings" }
    ]};
    this.documentationsMenu = {header:{},items:[
      { title: "About", link: "/docs-about",    localizationPath:"sidebar.nav.DOCUMENTATION.About", icon:"icon-graduation" },
      { title: "Documentation", link: "/docs",  localizationPath:"sidebar.nav.DOCUMENTATION.Docs", icon:"icon-graduation" }
    ]};
  },
  data() {
    return {
      name: "Vinnitsky",
      productsMenu: {},
      documentationsMenu:{}
    };
  }
};
</script>
