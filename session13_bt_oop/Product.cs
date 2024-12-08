class Product
{
    private int productId;

    public int ProductId
    {
        get { return productId; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("ID must be greater than zero");
            }
            productId = value;
        }
    }
    
    // 5 loại lỗi hệ thống 
    // 1. lỗi logic và tham số
    // 2. lỗi dữ liệu 
    // 3. lỗi hệ thống
    // 4. Lỗi I/O và mạng 
    // 5. 
    private string productName;

    public string ProductName
    {
        get { return productName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Product name cannot be empty");
            }
            productName = value;    
        }
    }
    private double price;

    public double Price
    {
        get { return price; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Price must be greater than zero");
            }
            price = value;
        }
    }
    
    private string description;

    public string Description
    {
        get { return description; }
        set
        {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Description must not be empty");
            }
            description = value;
        }
    }

    public Product(int productId, string productName, double price, string description)
    {
        ProductId = productId;  
        ProductName = productName;
        Price = price;
        Description = description;
    }

    public virtual void displayInfo()
    {
        Console.WriteLine("Product ID: " + ProductId);
        Console.WriteLine("ProductName: " + ProductName);
        Console.WriteLine("Price: "  + Price);
        Console.WriteLine("ProductDescription: " + Description);
        
    }
}