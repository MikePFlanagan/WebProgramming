<template>
  <div class="home">
   
        
        <h1 id="head1">I like to code. </h1>
        
           
        

           <p>

 <!-- This code makes a geolocator button its technically javascript but I liked the element -->
<button onclick="getLocation()">Get Latitude and Longitude</button>

<p id="Geolocation"></p>



        
        <h2>I Will code for food.</h2>
        
        <P> This is the start of my portfolio. So far this thing is strictly in Html.
            As I progress in web programming hopefully i can make this thing way cooler.
            With splashy graphics and stuff. So I can wow potential female companions and employers with my awesome (or not so awesome skills)
        </p>
        <h3>I will also code for money.</h3>
<p1>I am a college student and i have been in school for a rediculously long time. I am tired of being a poor boy. 
    If you can help me out that would cool. Ideally a job that pays 6 ^100000 dollars per minute, but whatever you can donate would be great.
I accept Cash App, Venmo, Google Pay, Paypal, Bitcoin, Etherium, basically whatever way of sending money you can think of I'll find a way to accept it if you I might plan on
putting easy links on the page here as well as some future point in time.        </p1> 
        <h3>I will also code if you pay my rent.</h3>
        <p2>
            This is pretty self explanatory as well. If you could pay my rent for me that would sweet.
        </p2> 
        
        
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
