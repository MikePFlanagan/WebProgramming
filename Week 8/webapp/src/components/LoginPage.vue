<template>
    <div>
        <h1>Student Registration</h1>
        <form>

            <div class="form-entry">
                First Name: <input id='first-name' type="text" v-model="firstName"/>
                <span id='first-name-error' v-bind:style="{visibility: firstNameErrorVisibility}">Please enter first name.</span>
            </div>

            <div class="form-entry">
                Last Name: <input id='last-name' type="text" v-model="lastName"/>
                <span id='last-name-error' v-bind:style="{visibility: lastNameErrorVisibility}">Please enter last name.</span>
            </div>

            <div class="form-entry">
                Birthdate:
                <br/>
                Month: <input id='birth-month' type="text" v-model="birthDay" size="2" maxlength="2"/>
                Day: <input id='birth-day' type="text" v-model="birthMonth" size="2" maxlength="2"/>
                Year: <input id='birth-year' type="text" v-model="birthYear" size="4" maxlength="4"/>
            </div>

            <div class="form-entry">
                <input type="button" value="Register" v-on:click="submitRegistration()"/>
            </div>

                  <div class="form-entry">
            UserName: <input id= 'user-name' type="text" v-model="userName"/>
            <span id='user-name-error' v-bind-style='{visibility: userNameErrorVisibility}'>Please enter Username.</span>
            </div>

            <div class="form-entry">
            Password: <input id='pass-word' type="text" v-model="passWord"/>
            <span id='pass-word-error' v-bind-style='{visibility: passWordErrorVisibility}'>>Please enter Password.</span>
            </div>

            <div class=form-entry>
            
            <input type="submit" value="Submit" onclick="validate()"/>
            
          </form>

          <div class="links"
          <span>
              <a href="index.html">Home</a>

        </form>
    </div>
</template>

<script>
   
    export default {
        name: 'Registration',
        methods: {
            submitRegistration: function() {
                this.userNameErrorVisibility = 'hidden';
                this.passWordErrorVisibility = 'hidden';
                if (this.userName.length == 0) {
                    this.userNameErrorVisibility = 'visible';
                    return;
                }
                if (this.passWordErrorVisibility.length == 0) {
                    this.passWordErrorVisibility = 'visible';
                    return;
                }
                
                alert('Logging in');
            }
        },
        data () {
            return {
                userName: '',
                passWord: '',                
                userNameErrorVisibility: 'hidden',
                passWordErrorVisibility: 'hidden'
            }
        }
    }
</script>

<style scoped>
    form {
        background-color: white;
        padding: 10px;
    }
    .form-entry {
        padding: 10px;
        background-color: lightgray;
    }
</style>