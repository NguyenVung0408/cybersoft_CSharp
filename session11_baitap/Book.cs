class Book{
    public string bookId;
    public string bookName;
    public string author;
    public float price;

    public Book (string bookId, string bookName, string author, float price){
        this.bookId = bookId;
        this.bookName = bookName;   
        this.author = author;
        this.price = price;

    }
    public void inforBook(){
        Console.WriteLine($"ID: {bookId}, Name: {bookName}, Author: {author}, price: {price}");
    }
}