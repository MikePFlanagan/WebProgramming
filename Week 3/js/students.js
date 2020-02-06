var students = '{ "students" : [ {"StudentID" : 1, "EmailAddress": "M.Jackson@ABCSchool.com"},{"StudentID": 2, "EmailAddress" : "Jackson@ABCSchool.com"},      {"StudentID": 3, "EmailAddress": "R.Jackson@ABCSchool.com"}, {"StudentID": 4, "EmailAddress": "T.Jackson@ABCSchool.com"},{"StudentID": 5, "EmailAddress":"J.Jackson@ABCSchool.com"} ]}'
       
 function initializeStudents(){
     var data = getStudents();
     displayStudents(data.students);
 }      

function getStudents(){
return JSON.parse(students);
}



function displayStudents(students){
    var tableList = "";
    for(i = 0; i < students.length; i++){
        var StudentID = students[i].StudentID;
        var EmailAddress = students[i].EmailAddress;
        tableList += "<tr><td>" + StudentID + "</t><td>" + EmailAddress + "</td>";
    
        document.getElementById("Students-list").innerHTML = tableList;
    }
}
