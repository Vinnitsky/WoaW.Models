
<template >
    <div id="appFooter">
      <footer>
            <span>&copy; {{year}} - {{author}}</span>
        </footer>
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
