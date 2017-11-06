<template >

 <li class=" ">
                    <a href="#products" title="Products" data-toggle="collapse">                        
                        <div v-if="headerNumber!==null" class="pull-right label label-info">{{headerNumber}}</div>
                        <em class="icon-speedometer"></em>
                        <span data-localize="sidebar.nav.PRODUCTS.Header">{{header}}</span>
                    </a>
                    <ul id="products" class="nav sidebar-subnav collapse">
                        <!-- <li class="sidebar-subnav-header">MM</li>
                            <li class=" active">
                            <a href="/product-list" title="M1">
                                <em class="icon-list-group"></em>
                                <span  data-localize="sidebar.nav.PRODUCTS.List">List</span>
                            </a>
                        </li>
                        <li class=" ">
                            <a href="/product-new" title="M2">
                                <em class="icon-new"></em>
                                <span data-localize="sidebar.nav.PRODUCTS.New">New</span>
                            </a>
                        </li>
                        <li class=" ">
                            <a href="/product-settings" title="M3">
                                <span>Product Settings</span>
                            </a>
                        </li>
                        <li class=" ">
                            <a href="/fetch-data" title="M3">
                                <span>fetch data link</span>
                            </a>
                        </li>
                        <li class=" ">
                            <a href="/counter" title="M3">
                                <span>counter link</span>
                            </a>
                        </li> 
                        <li class=" ">
                            <router-link :to="links.productListLink">
                                 <span>list link (right)</span>
                            </router-link>
                        </li>
                        <li class=" ">
                            <a v-bind:href="links.productNewLink" >
                                <span>new link(wrong)</span>
                            </a>
                        </li>
                         <li class=" ">
                            <a v-bind:href="links.productNewLink" >
                                <span>new link(wrong)</span>
                                {{links.productNewLink}}
                            </a>
                        </li> -->
<!-- active -->
                        <li class=" " v-for="item in itemsSource" :key="item.title">
                           <router-link :to="item.link">
                               <!-- TODO: figute out how to setup attribute value from component -->

                                <div v-if="item.number!==null" class="pull-right label" v-bind="{class:item.numberClass}" >{{item.number}}</div>

                                <em class="icon-list-group"></em>
                                 <span data-localize="sidebar.nav.PRODUCTS.itemName">{{item.title}}</span>
                            </router-link>
                        </li>
                    </ul>
                </li>
</template>

<script>
export default {
  name: "productNaviControl",

  props: {
    itemsSource: {
      type: Array,
      //   required: true,
      default: function() {
        return [];
      }
    },
    header: {
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
    }
  },
  created() {},
  data() {
    return {};
  }
};
</script>