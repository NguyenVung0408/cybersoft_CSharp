using Newtonsoft.Json;
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ProductManager productManager = new ProductManager();
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\n=== Product Manager ===");
            Console.WriteLine("1. Add Electronic Product");
            Console.WriteLine("2. Add Fashion Product");
            Console.WriteLine("3. Display All Products");
            Console.WriteLine("4. Search By Name");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    productManager.addElectronic();
                    break;
                case 2:
                    productManager.addFashion();
                    break;
                case 3:
                    productManager.displayAllProduct();
                    break;
                case 4:
                    Console.WriteLine("Enter product name: ");
                    string name = Console.ReadLine();
                    productManager.searchProductsByName(name);
                    break;
                case 5:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
                    
            }
        }
    }
}