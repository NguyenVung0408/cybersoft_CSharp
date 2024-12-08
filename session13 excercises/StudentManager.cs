using System.Reflection.Metadata.Ecma335;

class StudentManager {
    private List<Student> students;

    public List<Student> Students {
        get { return students; }
        set { students = value; }
    }

    public void addStudent(Student student) {
        students.Add(student);
    }

    public void findStudent (string studentName) {
        return students.FirstOrDefault(student => student.studentName.Contains(studentName, StringComparison.OrdinalIgnoreCase));

    }

    public bool updateScore(string studentId, double mathScore, double literatureScore, double englishScore) {
        var student = students.FirstOrDefault(student => student.StudentId == studentId);
        if (student != null) {
            student.MathScore = mathScore;
            student.EnglishScore = englishScore;
            student.LiteratureScore = literatureScore;
            return true;
        }
        return false;
    }

    public bool removeStudent(string studentId) {
        var student = students.FirstOrDefault(student => student.StudentId == studentId);
        if (student != null) {
            students.Remove(student);
            return true;
        }
        return false;
    }
}


