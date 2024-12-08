using Newtonsoft.Json;

class ProductManager
{
    private List<Product> products;

    public string filePath = "product.json";

    private void loadData()
    {
        if (!File.Exists(filePath))
        {
            products = new List<Product>();
        }
        else
        {
            string json = File.ReadAllText(filePath);
            products = JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }

    public ProductManager()
    {
        loadData();
    }

    private void saveData()
    {
        string json = JsonConvert.SerializeObject(products, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
        saveData();
    }

    public void addElectronic()
    {
        Console.WriteLine("Enter product ID: ");
        int productID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter product name: ");
        string productName = Console.ReadLine();
        Console.WriteLine("Enter product price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter decription: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter warranty date: ");
        int warranty = Convert.ToInt32(Console.ReadLine());
        Electronic electronic = new Electronic(productID, productName, price, description, warranty);
        AddProduct(electronic);
    }

    public void addFashion()
    {
        Console.WriteLine("Enter product ID: ");
        int productID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter product name: ");
        string productName = Console.ReadLine();
        Console.WriteLine("Enter product price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter decription: ");
        string decription = Console.ReadLine();
        Console.WriteLine("Enter product size: ");
        string size = Console.ReadLine();
        Fashion fashion = new Fashion(productID, productName, price, decription, size);
        AddProduct(fashion);
        
    }

    public void displayAllProduct()
    {
        //sắp xếp giảm dần theo giá 
        products.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));
        foreach (Product product in products)
        {
            product.displayInfo();
            Console.WriteLine("======================================");
        }
    }

    public void searchProductsByName(string name)
    {
        Product product = products.Find(p => p.ProductName.ToLower().Contains(name.ToLower()));
        if (product != null)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            product.displayInfo();
        }
    }
}