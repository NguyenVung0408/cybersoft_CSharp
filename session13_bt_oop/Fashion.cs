class Fashion : Product
{
    private string size;

    public string Size
    {
        get { return size; }
        set
        {
            List<string> validSizes = new List<string>{"S", "M", "L", "Xl", "XXl"};
            if (string.IsNullOrEmpty(value) || !validSizes.Contains(value))
            {
                throw new ArgumentException("Size must be one of S, M, L, Xl, XXl");
            }
            size = value;
        }
    }

    public Fashion(
        int productId,
        string productName,
        double price,
        string description,
        string size) : base(productId, productName, price, description)
    {
        Size = size;
    }

    public override void displayInfo()
    {
        base.displayInfo();
        Console.WriteLine("Size: " + Size);
        
    }
}