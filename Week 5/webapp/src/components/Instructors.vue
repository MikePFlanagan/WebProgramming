


<template>
 <div class="home">
    
     
        <h1>List of Instructors</h1>
 
        <table>
        <thead>
          <th>First Name</th>
          <th>Middle Initial</th>
          <th>Last Name</th>
          </thead>

          <tbody id="Instructors-List">

          </tbody>

      </table>
        
  </div>
</template>

<script>
export default {
  name: 'Home'
 
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
body {
    background-color: lightblue;
  }
  
  #head1 {
    color:rgb(216, 68, 68);
    font-size: 18;
    background-color: rgb(127, 47, 255);
    margin-left: 20px;
  }

  h2{
      color: black;
    margin-left: 20px;

  }

  h3{
    color: black;
  margin-left: 20px;

}

  p{
      color:rgb(255, 0, 13);
      text-align: center;
      font-size: large;
  }
  p2{
    color:rgb(55, 0, 255);
    text-align: center;
    font-size: large;
}

p3{
    color:rgb(38, 0, 255);
    text-align: center;
    font-size: large;
}



   
  th.greencolor{
    font-size: 18;
    color: green;
    font-weight: bold;
    border: 1px solid black;
    border-collapse: collapse;
    text-align: left;
}

table{
    border: 10px solid greenyellow;
    border-collapse: collapse;

}
</style>
