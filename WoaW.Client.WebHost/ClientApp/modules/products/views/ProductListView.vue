<template>
    <div id="productListView" class="content-wrapper">
        <div class="content-heading">Products</div>
        <product-list v-bind:itemsSource="products" />
    </div>
</template>

<style lang="scss">
    //https://github.com/vuejs-templates/webpack/issues/604 // https://stackoverflow.com/questions/43784202/how-to-include-css-files-in-vue-2 // @import "vendor/datatables-colvis/css/dataTables.colVis.css"; // @import "vendor/datatables/media/css/dataTables.bootstrap.css"; // // @import "datatables-bootstrap/css/dataTables.bootstrap.css"; // @import "vendor/dataTables.fontAwesome/index.css"; @import "../../../../wwwroot/vendor/datatables-colvis/css/dataTables.colVis.css"; @import "../../../../wwwroot/vendor/datatables/media/css/dataTables.bootstrap.css"; // @import "datatables-bootstrap/css/dataTables.bootstrap.css"; @import "../../../../wwwroot/vendor/dataTables.fontAwesome/index.css";
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

    export const HTTP = axios.create({
        baseURL: "http://localhost:7001/",
        //timeout: 10000,
        //withCredentials: true,
        //transformRequest: [(data) => JSON.stringify(data.data)],
        headers: {
            //Authorization: "Bearer {token}",
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Access-Control-Allow-Origin': '*'
        }
    });

    //import VueResource from 'vue-resource'
    //Vue.use(VueResource)
    ////Vue.http.options.xhr = { withCredentials: true }
    //Vue.http.headers.common['Content-Type'] = 'application/json'
    //Vue.http.headers.common['Access-Control-Allow-Origin'] = '*'
    //Vue.http.headers.common['Accept'] = 'application/json, text/plain, */*'
    //Vue.http.headers.common['Access-Control-Allow-Headers'] = 'Origin, Accept, Content-Type, Authorization, Access-Control-Allow-Origin'
    ////Vue.http.headers.common['Access-Control-Allow-Origin'] = 'http://localhost:7002/'
    ////Vue.http.headers.common['Access-Control-Request-Method'] = '*'

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
            this.products = [];
            this.refrashPage();
        },
        methods: {
            refrashPage() {
                HTTP
                    .get("api/ProductData/") //.get("/api/status/${this.item.id}")
                    .then(res => {
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
