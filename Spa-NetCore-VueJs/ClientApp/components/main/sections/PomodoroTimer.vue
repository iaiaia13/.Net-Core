<template>
  <div>
    <count-down-timer :time="time"></count-down-timer>
  </div>
</template>
<script>
  import CountDownTimer from './timer/CountDownTimer'
  export default {
    components: {
      CountDownTimer
    },
    computed:{
      time(){
        return 25 * 60
      }
    }
  }
</script>
<style scoped lang="scss">

</style>
