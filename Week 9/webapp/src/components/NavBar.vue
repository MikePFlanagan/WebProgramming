<template>
    <div class="menu-bar">
     <div v-if="!$auth.loading">
        <span v-if="$auth.isAuthenticated" class="menu-item" v-on:click='goToHome'>Home</span>           
        <span v-if="$auth.isAuthenticated" class="menu-item" v-on:click='goToInstructors'>Instructors</span>
        <span v-if="$auth.isAuthenticated" class="menu-item" v-on:click='goToStudents'>Students</span>          
        <span v-if="$auth.isAuthenticated" class="menu-item" v-on:click='goToRegistration'>Registration</span>        
         <!-- show login when not authenticated -->
        <button v-if="!$auth.isAuthenticated" class="menu-item" @click="login">Login</button>
      <!-- show logout when authenticated -->
        <button v-if="$auth.isAuthenticated" class="menu-item" @click="logout">Logout</button>
    </div>
  </div>    
</template>

<script>
  export default {
    name: 'NavBar',
    methods: {   
      goToHome: function() {
        this.$router.push({ path: 'home' })
      },
      goToInstructors: function() {
        this.$router.push({ path: 'instructors' })
      },
      goToStudents: function() {
        this.$router.push({ path: 'students' })
      },
      goToLoginPage: function() {
        this.$router.push({ path: 'loginpage' })
      },
         // Log the user in
      login() {
      this.$auth.loginWithRedirect();
    }, 
    // Log the user out
    logout() {
      this.$auth.logout({
        returnTo: window.location.origin
      });
    }
    }
  }      
</script>


  <style scoped>
    .menu-item {
        margin-left: 10px;
        padding: 5px;
    }
    .menu-bar {
        background-color: cyan;
        height: 40px;
        margin-top: 10px;
        vertical-align: middle;
        padding-top: 20px;
        width: 50%;
    }
  
</style>