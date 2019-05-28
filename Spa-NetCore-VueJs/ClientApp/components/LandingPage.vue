<template>
  <div>
    <logo></logo>
    <tag-line></tag-line>
    <authentication></authentication>
    <go-to-app-link></go-to-app-link>
  </div>
</template>
<script>
import { Authentication, GoToAppLink, TagLine } from "./landing";
import { Logo } from "./common";
export default {
  name: "landing-page",
  components: {
    Logo,
    Authentication,
    GoToAppLink,
    TagLine
  }
};
</script>
<style scoped lang="sass">

</style>
