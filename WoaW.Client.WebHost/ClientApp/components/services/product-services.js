export default {
    name: "ProductService",
    data() {
      return {
        status: {},
        errors: []
      };
    },
    created() {
      this.getProducts();
    },
    methods: {
      getProducts() {
        axios
          .get("/api/status/${this.item.id}")
          .then(res => {
            this.status = res.data.status;
          })
          .catch(e => {
            this.errors.push(e);
          });
      }
    }
  };
