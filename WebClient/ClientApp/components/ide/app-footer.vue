
<template >
    <div id="appFooter">
        <span>&copy; {{year}} - {{author}}</span>
    </div>
</template>

<script>
export default {
  name: "app-footer",
  data() {
    return {
      year: 2017,
      author: "Vinnitsky"
    };
  }
};
</script>
