<template >

 <li class=" " >
     <!-- v-bind="{'href':headerLink}" -->
                    <!-- <a href="#products" title="Products" data-toggle="collapse" > -->
                    <!-- <a   v-bind:href="{headerLink}" v-bind="{'title':headerText}" data-toggle="collapse"> -->
                    <a v-bind="{'title':headerText}" data-toggle="collapse"  v-on:click="onHeaderClick">
                        <div v-if="headerNumber!==undefined" class="pull-right label label-info">{{headerNumber}}</div>
                        <em class="icon-speedometer" v-bind="{class:headerIcon}"></em>
                        <span v-bind="{'data-localize':headerLocalizationPath}">{{headerText}}</span>
                    </a>
                    <ul v-bind="{'id':headerText}" class="nav sidebar-subnav " v-bind:class="{collapse:isHeaderActive}"   >
<!-- active -->
                        <li class=" " v-for="item in itemsSource" :key="item.title"
                        v-bind:class="{active:isItemActive}" v-on:click="onItemClick">
                        <!-- <li class=" " v-for="item in itemsSource" :key="item.title"
                            v-bind:class="{active:isItemActive}"> -->
                           <router-link :to="item.link">
                                <div v-if="item.number!==undefined" class="pull-right label " v-bind="{class:item.numberClass}" >{{item.number}}</div>
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
    },
headerLink: {
      type: String,
      default: function() {
        return "#";
      }
    },
    headerLocalizationPath: {
      type: String,
      default: function() {
        return "Item localizatin path";
      }
    }
  },
  computed:{
    //   headerLink:{
    //     cached: false,
    //     get: function () {
    //         return '#'+this.headerText;
    //     },
    //     set: function (value) {
    //     }
    // }
  },
  created() {},
  data() {
    return {
        isHeaderActive:false,
        isItemActive:false
    };
  },
  methods:{
      onHeaderClick(item)
      {
          this.isHeaderActive=!this.isHeaderActive;
      },
      onItemClick()
      {
          this.isItemActive = !this.isItemActive;
      }
  }
};
</script>
