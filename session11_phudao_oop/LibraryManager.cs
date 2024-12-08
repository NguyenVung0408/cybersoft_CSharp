using System.ComponentModel;
using Newtonsoft.Json;
class LibraryManager{
    public string libraryId;
    public string libraryName;
    public List<Book> books;
    public string filePath = "Library.json";// file lưu thông tin sách

    // do hàm load file hay read file chỉ dùng trong class LibraryManager nên đặt là private
    private void loadFromFile() { // Dùng khi khởi tạo class LibraryManager
        if (File.Exists(filePath)) { // nếu tìm thấy file
            string json = File.ReadAllText(filePath);// đọc file

            // chuyển json thành danh sách
            books = JsonConvert.DeserializeObject<List<Book>>(json);
            Console.WriteLine("Load file thành công!");
        }
        else{
                books = new List<Book>(); // nếu ko tìm thấy file tạo danh sách mới 
                Console.WriteLine("File không tồn tại. Tạo mới danh sách");
        }
    }

    private void saveToFile(){ // Dùng sau khii Add hoặc Remove sách
        //B1: chuyển danh sách thành json 
        //Formatting.Indented: để json được hiển thị dễ đọc 
        string json = JsonConvert.SerializeObject(books, Formatting.Indented);

        //B2: Lưu vào file json 
        File.WriteAllText(filePath, json);
        Console.WriteLine("Lưu file thành công!");
    }
    
    public LibraryManager(string libraryId, string libraryName) {
        this.libraryId = libraryId;
        this.libraryName = libraryName; 
        loadFromFile();// load file json khi khởi tạo class LibraryManager
    }
     public void addBook(Book book) {
        // kiểm tra xem mã sách đã tồn tại chưa
        // lambda expression
        if (books.Any(b => b.bookId == book.bookId)) {
            Console.WriteLine("Mã sách đã tồn tại. Vui lòng nhập mã khác!");
        } else {
            books.Add(book); // thêm sách vào danh sách
            saveToFile(); // lưu file json
            Console.WriteLine("Thêm sách thành công!");
        }
    }

    
    // Hàm thêm TextBook
    public void addTextBook(){
        Console.WriteLine("Nhập mã sách: ");
        string? bookId = Console.ReadLine();

        Console.WriteLine("Nhập tên sach: ");
        string? bookName = Console.ReadLine();

        Console.WriteLine("Nhập tác giả: ");
        string? author = Console.ReadLine();
        
        Console.WriteLine("Nhập giá sách: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập môn học: ");
        string? subject = Console.ReadLine();    
        
        Console.WriteLine("Nhập lớp: ");
        string? grade = Console.ReadLine();

        TextBook textBook = new TextBook(bookId, bookName, author, price, subject, grade);
        addBook(textBook);
    }

    // Hàm thêm ReferenceBook
    public void addReferenceBook(){
        Console.WriteLine("Nhập mã sách: ");
        string? bookId = Console.ReadLine();

        Console.WriteLine("Nhập tên sach: ");
        string? bookName = Console.ReadLine();

        Console.WriteLine("Nhập tác giả: ");
        string? author = Console.ReadLine();
        
        Console.WriteLine("Nhập giá sách: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập chủ đề: ");
        string? topic = Console.ReadLine();

        Console.WriteLine("Nhập nhà xuất bản: ");
        string? publisher = Console.ReadLine();  

        ReferenceBook referenceBook= new ReferenceBook(bookId, bookName, author, price, topic, publisher);
        addBook(referenceBook);
    }

    // Hàm thêm FictionBook
    public void addFictionBook(){
         Console.WriteLine("Nhập mã sách: ");
        string? bookId = Console.ReadLine();

        Console.WriteLine("Nhập tên sách: ");
        string? bookName = Console.ReadLine();

        Console.WriteLine("Nhập tác giả: ");
        string? author = Console.ReadLine();
        
        Console.WriteLine("Nhập giá sách: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập thể loại sách: ");
        string? genger = Console.ReadLine();

        Console.WriteLine("Nhập năm sản xuất của sách: ");
        int year = Convert.ToInt32(Console.ReadLine());

        FictionBook fictionBook= new FictionBook(bookId, bookName,author, price, genger, year);
        addBook(fictionBook);

    }
    // Hàm hiển thị danh sách các sách trong thư viện 
    public void displayAllBooks(){
            Console.WriteLine("\n=== Library Books ===" );
            if (books.Count == 0 ){
                Console.WriteLine("Không có sách nào trong thư viện!");
                return;

            }
            foreach(Book book in books){
                book.displayInfo();

        }
    }
}
