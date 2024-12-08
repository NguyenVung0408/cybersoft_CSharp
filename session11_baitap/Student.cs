class Student{
    public string studentId;
    public string studentName;
    public int age;

    public Student (string studentId, string studentName, int age){
        this.studentId = studentId;
        this.studentName = studentName;
        this.age = age;
    }


    public void displayInfo(){
        Console.WriteLine($"ID: {studentId}, Name: {studentName}, Age: {age}");
    }
}