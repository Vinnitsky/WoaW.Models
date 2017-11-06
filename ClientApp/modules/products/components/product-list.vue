<template >
    <div id="productList" class="table-responsive b0">
        <div v-if="itemsSource.length ===0">
            {{emptyContainerHint}}
        </div>

        <table id="datatable1" class="table table-striped table-hover">
            <thead>
                <tr>
                <th style="width:80px">
                    <strong>ID</strong>
                </th>
                <th>
                    <strong>NAME</strong>
                </th>
                <th>
                    <strong>DESCRIPTION</strong>
                </th>
                <th>
                    <strong>PRICE</strong>
                </th>
                <th style="width:80px">
                    <strong>QUANTITY</strong>
                </th>
                <th class="text-center">
                    <strong>STATUS</strong>
                </th>
                <th>
                    <strong>ADDED</strong>
                </th>
                <th class="text-center">
                    <strong>VIEW</strong>
                </th>
                </tr>
            </thead>
            <tbody>               
                <tr v-for="item in itemsSource" :key="item.Id">
                <td>{{item.id}}</td>
                <td>{{item.name}}</td>
                <td>{{item.description}}</td>
                <td>{{item.price}}</td>
                <td>{{item.quantity}}</td>
                <td class="text-center">
                    <span class="label label-success" :class="toEnum(item).css">{{toEnum(item).text}}</span>
                </td>
                <td>{{item.added}}</td>
                <td class="text-center">
                    <button type="button" class="btn btn-sm btn-default">
                        <em class="fa fa-search"></em>
                    </button>
                </td>
                </tr>

            </tbody>
        </table>
    </div>
</template>

<script>
// https://www.youtube.com/watch?v=RjU8dB2vrE8&t=204s
export default {
  name: "productList",
  props: {
    itemsSource: {
      type: Array,
      //   required: true,
      default: function() {
        return [];
      }
    },
    emptyContainerHint: {
      type: String,
      default: function() {
        return "Collection is empty";
      }
    }
  },
  created() {},
  data() {
    return {};
  }, 
  methods: {
    refresh() {},
    toEnum(item) {
      switch (item.status) {
        case 1:
          return { css: "label label-success", text: "Stock" };
          break;
        case 2:
          return { css: "label label-warning", text: "Out of stock" };
          break;
        case 3:
          return { css: "label label-danger", text: "Removed" };
          break;
        default:
          return { css: "label label-success", text: "Stock" };
      }
    }
  }
};
</script>
