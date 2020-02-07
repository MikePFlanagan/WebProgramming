 var instructors = '{ "instructors" : [ {"FirstName" : "James", "MiddleInitial": "T","LastName" : "Kirk"}, {"FirstName": "Schn", "MiddleInitial" : "Tgai", "LastName" : "Spock"}, {"FirstName": "Benjamin", "MiddleInitial" "L", "LastName" : "Sisko"}, {"FirstName": "Jean", "MiddleInitial" "L", "LastName" : "Picard"},{"FirstName" : "Kathryn", "MiddleInitial": "H","LastName" : "Janeway"}, {"FirstName": "Jonathan", "MiddleInitial" : "P", "LastName" : "Archer"}]}';
       
 function initializeInstructors(){
     var data = getInstructors();
     displayInstructors(data.instructors);
 }      

function getInstructors(){
return JSON.parse(instructors);
}



function displayInstructors(instructors){
    var tableList = "";
    for(i = 0; i < instructors.length; i++){
        var FirstName = instructors[i].FirstName;
        var MiddleInitial = instructors[i].MiddleInitial;
        var LastName = instructors[i].LastName;
        tableList += "<tr><td>" + FirstName + "</t><td>" + MiddleInitial + "</t><td>" + LastName + "</t><td>";
    
        document.getElementById("Instructors-List").innerHTML = tableList;
    }
}
