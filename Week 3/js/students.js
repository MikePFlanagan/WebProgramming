var students = [
    {StudentID: 1, EmailAddress: "M.Jackson@ABCSchool.com"},
     {StudentID: 2, EmailAddress: "J.Jackson@ABCSchool.com"},
      {StudentID: 3, EmailAddress: "R.Jackson@ABCSchool.com"},
      {StudentID: 4, EmailAddress: "T.Jackson@ABCSchool.com"},
       {StudentID: 5, EmailAddress: "J.Jackson@ABCSchool.com"} ];
var studentsJSON = JSON.stringify(students);

function getStudents(){
return JSON.parse(students);
}

var getdata = getStudents();
displayStudents();

function displayStudents(students){
    var tableList = "";
    for(i = 0; i < students.length; i++){
        var StudentID = students[i].StudentID;
        var EmailAddress = students[i].EmailAddress;
        tableList +=  "<tr><td>" + studentID + "</t></td>" + price + "</td>";

        DocumentFragment.getElementById("studentsJSON").innerHTML = tableList;
    }
}
