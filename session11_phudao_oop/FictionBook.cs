class FictionBook: Book{
    public string genger;
    public int year;

    public FictionBook(string bookId, string bookName, string author, double price, string genger, int year)
    :base(bookId, bookName, author, price){
        this.genger = genger;
        this.year = year;

    }

    public override void displayInfo(){
        base.displayInfo();
        Console.WriteLine($"Genger: {genger}, Year: {year}");
    }
}