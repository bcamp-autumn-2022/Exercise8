// See https://aka.ms/new-console-template for more information
using Exercise8;

Console.WriteLine("Hello, World!");

Student objectStudent=new Student("Teppo","Testi");
Console.WriteLine(objectStudent.Fname+" "+objectStudent.Lname);

List<Student> studentsCollection = new List<Student>();
 studentsCollection.Add(new Student { Fname = "Ann", Lname="Simpson" });
 studentsCollection.Add(new Student { Fname = "Jim", Lname="Smith" });
 
 studentsCollection.Add(new Student("Bob","Smith"));


 foreach(Student stu in studentsCollection){
    Console.WriteLine(stu.Fname+" "+stu.Lname);
 }
 var chosenStudents = from chosenStu in studentsCollection
 where chosenStu.Lname.Equals("Smith")
 select chosenStu;

Console.WriteLine("Chosen Students");
  foreach(Student stu in chosenStudents){
    Console.WriteLine(stu.Fname+" "+stu.Lname);
 }