<template >
    <div id="productListView" class="content-wrapper">
        <div class="content-heading">Products</div>
        <product-list v-bind:itemsSource="products"/>
    </div>
</template>

<style lang="scss">
//https://github.com/vuejs-templates/webpack/issues/604
// https://stackoverflow.com/questions/43784202/how-to-include-css-files-in-vue-2
// @import "vendor/datatables-colvis/css/dataTables.colVis.css";
// @import "vendor/datatables/media/css/dataTables.bootstrap.css";
// // @import "datatables-bootstrap/css/dataTables.bootstrap.css";
// @import "vendor/dataTables.fontAwesome/index.css";
@import "../../../../wwwroot/vendor/datatables-colvis/css/dataTables.colVis.css";
@import "../../../../wwwroot/vendor/datatables/media/css/dataTables.bootstrap.css";
// @import "datatables-bootstrap/css/dataTables.bootstrap.css";
@import "../../../../wwwroot/vendor/dataTables.fontAwesome/index.css";
</style>

<script>
//https://docs.npmjs.com/files/package.json
//https://stackoverflow.com/questions/14381898/local-dependency-in-package-json
import "jquery.dataTables.min.js/js/jquery.dataTables.min.js";
import "vendor/datatables-colvis/js/dataTables.colVis.js";
import "dataTables-bootstrap/js/dataTables.bootstrap.js";
import ProductListComponent from "modules/products/components/product-list";
import axios from "axios";
// import "../../../wwwroot/js/demo/demo-datatable.js";
// import ProductService from "comonents/services/product-services";

export default {
  components: { "product-list": ProductListComponent },
  name: "productListView",
  data() {
    return {
      status: {},
      products: {},
      errors: []
    };
  },
  created() {
    this.products = [
      {
        Id: "0001",
        Name: "Product 1",
        Description: "Description for Product",
        Price: "$12.36",
        Quantity: 243,
        status: 1,
        Added: "04/10/2017"
      },
      {
        Id: "0002",
        Name: "Product 2",
        Description: "Description for Product",
        Price: "$12.36",
        Quantity: 243,
        status: 2,
        Added: "04/10/2017"
      },
      {
        Id: "0003",
        Name: "Product 3",
        Description: "Description for Product",
        Price: "$12.36",
        Quantity: 243,
        status: 3,
        Added: "04/10/2017"
      }
    ];
    // this.products=[];
    //this.refrashPage();
  },
  methods: {
    refrashPage() {
      axios
        .get("http://localhost:5000/api/ProductData/WeatherForecasts") //.get("/api/status/${this.item.id}")
        .then(res => {
          debugger;
          this.products = res.data;
          this.status = res.status;
          console.log(this.products);
        })
        .catch(e => {
          debugger;
          this.errors.push(e);
        });
    }
    // refrashPage: async function() {
    //   //   this.products = await ProductService.getProducts();
    //   try {
    //     debugger;
    //     const response = await axios.get(
    //       "http://localhost:5000/api/ProductData/WeatherForecasts"
    //     );
    //     this.products = response.data;
    //   } catch (e) {
    //     debugger;
    //     this.errors.push(e);
    //   }
    // }
  }
};
</script>
