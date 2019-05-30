<template>
  <div id="app-root">
    <h1>Welcome to Profitoro</h1>
    <main-content></main-content>
  </div>
</template>
  
  <script>
import MainContent from "../MainContent.vue"
import LandingPage from "../LandingPage.vue"
export default {
  name: "app-root",
  components: {
    MainContent,
    LandingPage
  }
};
</script>
  
  <style>
</style>