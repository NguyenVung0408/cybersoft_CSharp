class Person{
    private string name;
    private int age;

    // Dùng property để truy cập vào từng thuộc tính 
    public string Name { 
        get { return name; }
    set {
        // Thêm các logic kiểm tra giá trị trước khi gán cho thuộc tính 
        // Check tên không được rỗng 
        // Hoặc check tên có độ dài tối thiểu là 2 ký tự 
        if (string.IsNullOrEmpty(value) || value.Length < 2) {
            throw new ArgumentException("Tên không hợp lệ");    
        }
        name = value; 
        }
    }

    public int Age {
        get { return age; }
        set {
            if(value < 0 || value > 150) {
                throw new ArgumentException("Tuổi không hợp lệ");
            }
            age = value;
        }
    }

    public Person(string name, int age) {
        // Gán giá trị cho thuộc tính thông qua setter (quan trọng)
        Name = name;
        Age = age;
    }

    public Person (){}
}