



using Newtonsoft.Json;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        #region Bai 1: Quan ly lop hoc

        //B1: Quản lý lớp học
        // 1. Lớp học 
        // - tạo lớp Classroom để quản lý lớp học 
        // - classId: mã lớp học 
        // - className: tên lớp học
        // danh sách sinh viên trong lớp 
        // 2. Sinh viên 
        // - studentId: mã sinh viên
        // - studentName: tên sinh viên
        // - age: tuổi
        // 3. Yêu cầu chức năng 
        // - Thêm sinh viên vào lớp
        // - Hiển thị danh sách sinh viên trong lớp 
        // - Tìm sinh viên theo mã sinh viên 


        // Tạo lớp học 
        Classroom classroom = new Classroom("C02", "Dotnet02");
        // tạo menu quản lý sinh viên 
        // 1. Thêm sinh viên 
        // 2. Hiển thị danh sách sinh viên 
        // 3. Tìm kiếm sinh viên theo mã sinh viên 
        // 4. Thoát 

        while(true){
            Console.WriteLine("\n ----Classroom Management----");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Show students");
            Console.WriteLine("3. Find student by studentId");
            Console.WriteLine("4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                // Thêm sinh viên
                Console.WriteLine("Enter student ID:");
                string? studentId = Console.ReadLine();
                Console.WriteLine("Enter student name:");
                string? studentName = Console.ReadLine();
                Console.WriteLine("Enter student age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Student student = new Student(studentId, studentName, age);

                // Thêm sinh viên vào lớp 
                classroom.addStudent(student);

                // Lưu danh sách sinh viên vào json 

                // Chuyển danh sách sinh viên thành json 

                var json = JsonConvert.SerializeObject(classroom.students, Formatting.Indented);

                // Lưu json vào file
                File.WriteAllText("students.json", json);

                Console.WriteLine("Add student successfully");
                break;
                case 2:
                // Hiển thị danh sách sinh viên đã lưu 

                // Đọc danh sách sinh viên từ file json 
                var studentsJson = File.ReadAllText("students.json");

                // Chuyển json thành danh sách sinh viên 
                classroom.students = JsonConvert.DeserializeObject<List<Student>>(studentsJson);
                // Hiển thị danh sách sinh viên 
                classroom.showStudents();
                break;
                case 3:
                // Tìm kiếm sinh viên theo mã sinh viên
                Console.WriteLine("Enter student ID to find: ");
                string? id = Console.ReadLine();
                if (id == null){
                    Console.WriteLine("Student ID is required");
                    break;
                }
                classroom.findStudentByStudentId(id);
                break;
                case 4: 
                // Thoát
                return;
                default:
                Console.WriteLine("Invalid choice. Please enter 1-4 ");
                break;

            }
        }  

        #endregion
        #region Bai 2: Quan ly thu vien 
        // 1. Tạo class Book để quản lý danh sách
        // - bookId: mã sách
        // - bookName: tên sách 
        // - author: tác giả 
        // - price: giá sách 
        // -------------------
        // 2. Tạo class Library để quản lý thư viện 
        // - libraryId: mã thư viện 
        // - libraryName: tên thư viện 
        // - danh sách book trong thư viện 
        // ----------------------------------
        // 3. Yêu cầu chức năng
        // - Thêm sách vào thư viện
        // - Hiển thị danh sách sách trong thư viện 
        // - Tìm sách theo mã sách 
        // - Thoát 
        #endregion
    
    }
}