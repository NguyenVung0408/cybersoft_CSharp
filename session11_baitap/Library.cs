class Library{
    public string libraryId;
    public string libraryName;
    public List<Book> books;

    public Library(string libraryId, string libraryName){
        this.libraryId = libraryId;
        this.libraryName = libraryName;
        this.books = new List<Book>();
    }

    public void addBook(Book book){
        books.Add(book);
        Console.WriteLine($"Book {book.bookName} added to library {libraryName}");
    }

    public void showBook(){
        Console.WriteLine($"\n ---- Books in library {libraryName}----");
        foreach(Book book in books){
            book.inforBook();
        }
    }

    public void findBookByBookId(string bookId){
        foreach(Book book in books){
            if(book.bookId == bookId){
                book.inforBook();
                return;
            }
        }
        Console.WriteLine($"Book with ID {bookId} not found in class {libraryName}");
    }

 }