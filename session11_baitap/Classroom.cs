using System.Diagnostics.Contracts;

class Classroom{
    // thuộc tính 
    public string classId;
    public string className;
    public List<Student> students;

    //contructor

    public Classroom(string classId, string classname){
        this.classId = classId;
        this.className = classname; 
        this.students = new List<Student>();

    }

    // Phương thức thêm sinh viên vào lớp 
    public void addStudent(Student student){
        students.Add(student);
        Console.WriteLine($"Student {student.studentName} added to class {className}");
    }

    // Phương thức hiện thị danh sách sinh viên trong lớp

    public void showStudents(){
        Console.WriteLine($"\n ----Students in class {className}----");
        foreach(Student student in students){
            student.displayInfo();
        }
    }

    // Phương thức tìm kiếm sinh viên theo mã sinh vieen 

    public void findStudentByStudentId(string studentId){
        foreach(Student student in students){
            // Dùng vòng lặp
            if(student.studentId == studentId){
                student.displayInfo();
                return;

            }
        }
        Console.WriteLine($"Student with ID {studentId} not found in class {className}");
    }
}
