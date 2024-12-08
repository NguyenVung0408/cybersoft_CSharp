class Electronic: Product
{
    private int warranty;

    public int Warranty
    {
        get { return warranty; }
        set {
            if (value < 0)
            {
                throw new ArgumentException( "Warranty must be greater than zero" );
            }
            warranty = value; 
        }
    }

    public Electronic(
        int productID,
        string productName,
        double price,
        string description,
        int warranty): base(productID, productName, price, description)
    {
        Warranty = warranty;
    }

    public override void displayInfo()
    {
        base.displayInfo();
        Console.WriteLine("Warranty: " + Warranty);
    }
}