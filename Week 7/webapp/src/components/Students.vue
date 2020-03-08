<template>
    <div>
        <h2 class='section-heading'>Students</h2>
        <table>
            <thead>
                <tr>
                    <th>Student Id</th>
                    <th>Email Address</th>                   
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" v-bind:key="student">
                    <td>{{ student.StudentID}}</td>
                    <td>{{ student.EmailAddress }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    import Vue from 'vue'
    export default {
        name: 'Students',

            data () {
            return {
                products: [],
                operation: 'list',
                StudentID: undefined,
                EmailAddres: undefined,
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
             mounted() {
            this.getStudents();
            this.operation = 'list';
        }}}
</script>