 <template>
    <div>
        <h2 class='section-heading'>List of Instructors</h2>
        <table>
            <thead>
                <tr>
                    <th>FirstName</th>
                    <th>MiddleInitial</th>
                    <th>LastName</th>                    
                </tr>
            </thead>
            <tbody>
                <tr v-for="instructor in instructors" v-bind:key="instructor">
                    <td>{{ instructor.FirstName}}</td>
                    <td>{{ instructor.MiddleInitial}}</td>
                    <td>{{ instructor.LastName }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
    export default {
        name: 'Instructors',
        mounted() {
            this.instructors = getInstructors();
        },
        data () {
            return {
                instructors: []
            }
        }
    }
    function getInstructors() {
        return JSON.parse(instructors);
    }
    var instructors = '[{"FirstName": "James", "MiddleInitial": "T","LastName": "Kirk"}, {"FirstName": "Schn", "MiddleInitial": "Tgai", "LastName": "Spock"}, {"FirstName": "Benjamin", "MiddleInitial": "L", "LastName": "Sisko"}, {"FirstName": "Jean", "MiddleInitial": "L", "LastName": "Picard"},{"FirstName": "Kathryn", "MiddleInitial": "H","LastName": "Janeway"}, {"FirstName": "Jonathan", "MiddleInitial": "P", "LastName": "Archer"}]'
    
</script>

<style scoped>
    table, th, td {
        padding: 10px;
        border: 5px solid black; 
        border-collapse: collapse;
    }
</style>