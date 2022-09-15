namespace Exercise8
{
    public class Student
    {
        public Student(){}
        public Student(string fn, string ln){
            this.Fname=fn;
            this.Lname=ln;
        }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}