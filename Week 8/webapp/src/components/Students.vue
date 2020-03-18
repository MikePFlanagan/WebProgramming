<template>
    <div>
        <div v-if='operation == "list"'>
        <h2 class='section-heading'>Students</h2>
        <table>
            <thead>
                <tr>
                    <th>Student Id</th>
                    <th>Email Address</th>                   
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" :key="student.studentid">
                    <td>{{ student.studentId}}</td>
                    <td>{{ student.emailAddress }}</td>
                </tr>
            </tbody>
        </table>
    </div>
    </div>
</template>

<script>
    import Vue from 'vue'
    export default {
        name: 'Students',

            data () {
            return {
                students: [],
                operation: 'list',
                studentId: undefined,
                emailAddress: undefined,
                apiServer: process.env.VUE_APP_API_SERVER
            }
        },
    //     mounted() {
    //         this.students = getStudents();
    //     },
    //     data () {
    //         return {
    //             students: []
    //         }
    //     }
    // }
    // function getStudents() {
    //     return JSON.parse(students);
    // }
    // var students = '[{"StudentID": 1, "EmailAddress": "M.Jackson@ABCSchool.com"},{"StudentID": 2, "EmailAddress": "J.Jackson@ABCSchool.com"}, {"StudentID": 3, "EmailAddress": "R.Jackson@ABCSchool.com"}, {"StudentID": 4, "EmailAddress": "T.Jackson@ABCSchool.com"},{"StudentID": 5, "EmailAddress":"J.Jackson@ABCSchool.com"}]'
    methods: {
            getStudents: function() {
                let url = `http://${this.apiServer}/api/student`;

                Vue.axios.get(url).then(
                    (response) => {
                        this.students = response.data;
                        
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            }, 

            getStudent: function(studentId) {
                let url = `http://${this.apiServer}/api/student/${studentId}`;

                Vue.axios.get(url).then(
                    (response) => {
                        this.studentId = response.data.studentId;
                        this.emailAddress = response.data.emailAddress;
                        
                       
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
              displayAddStudent: function() {
                this.studentid = undefined;
                this.emailAddress = undefined;
                

                this.operation = 'add';
            },
              AddStudent: function() {
                let url = `http://${this.apiServer}/api/student`;

                Vue.axios.post(url, {
                    studentid: this.studentid,
                    emailaddress: this.emailaddress
                    
                }).then(
                    () => {
                        this.getStudents();
                        this.operation = 'list';
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
             displayStudentDetails: function(studentId) {
                this.getStudent(studentId);

                this.operation = 'detail';
            },
            displayUpdateStudent: function(studentId) {
                this.studentUpdateId = studentId;
                this.getStudents(studentId);

                this.operation = 'update';
            },

            updateStudent: function() {
                let url = `http://${this.apiServer}/api/student/${this.studentUpdateId}`;

                Vue.axios.put(url, {
                    studentid: this.studentid,
                    emailaddress: this.emailaddress,
                    
                }).then(
                    () => {
                        this.getStudents();
                        this.operation = 'list';
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },

            deleteStudent: function(studentId) {
                let url = `http://${this.apiServer}/api/student/${studentId}`;

                Vue.axios.delete(url).then(
                    () => {
                        this.getStudents();
                        this.operation = 'list';
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },

            cancel: function() {
                this.operation = 'list';
            }
        },
        
             mounted() {
            this.getStudents();
            this.operation = 'list';
        }}
</script>

 <style scoped>
         table {
        border-collapse: collapse;
    }

    table, th, td {
        border: 1px solid black;
        padding: 10px;
    }

    #addBtn {
        margin-top: 20px;
    }

    .form-entry {
        margin-top: 20px;
    }
 </style>