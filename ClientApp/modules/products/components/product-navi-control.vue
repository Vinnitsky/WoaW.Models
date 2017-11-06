<template >

 <li class=" ">
                    <a href="#products" title="Products" data-toggle="collapse">                        
                        <div v-if="headerNumber!==undefined" class="pull-right label label-info">{{headerNumber}}</div>
                        <em class="icon-speedometer" v-bind="{class:headerIcon}"></em>
                        <span data-localize="sidebar.nav.PRODUCTS.Header">{{headerText}}</span>
                    </a>
                    <ul id="products" class="nav sidebar-subnav collapse">
                        <!-- <li class="sidebar-subnav-header">MM</li>
                            <li class=" active">
                            <a href="/product-list" title="M1">
                                <em class="icon-list-group"></em>
                                <span  data-localize="sidebar.nav.PRODUCTS.List">List</span>
                            </a>
                        </li>
                      -->
<!-- active -->
                        <li class=" " v-for="item in itemsSource" :key="item.title">
                           <router-link :to="item.link">
                                <div v-if="item.number!==undefined" class="pull-right label" v-bind="{class:item.numberClass}" >{{item.number}}</div>
                                 <em v-if="item.icon!==undefined" v-bind="{'class':item.icon}"></em>                                
                                 <span  v-bind="{'data-localize':item.localizationPath}">{{item.title}}</span>
                            </router-link>
                        </li>
                    </ul>
                </li>
</template>

<script>
export default {
  name: "productNaviControl",

  props: {
    //   header:{
    //       type:Object,          
    //       default : function () {
    //           return{
    //               text:"HeaderText",
    //               number:3,
    //               icon:'icon-speedometer'
    //           };
    //       }
    //   },
    itemsSource: {
      type: Array,
      //   required: true,
      default: function() {
        return [];
      }
    },
    headerText: {
      type: String,
      default: function() {
        return "Menu Header";
      }
    },
    headerNumber: {
      type: String,
      default: function() {
        return "0";
      }
    },
    headerIcon: {
      type: String,
      default: function() {
        return "";
      }
    }
  },
  created() {},
  data() {
    return {};
  }
};
</script>