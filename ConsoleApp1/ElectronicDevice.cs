abstract class ElectronicDevice

{
    // private fields
    private string brand;
    private double price;

    // constructor to initialize brand and price
    public ElectronicDevice(string brand, double price)
    {
        this.brand = brand;
        this.price = price;
    }

    // public properties
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
            else
                Console.WriteLine("Price must be greater than 0");
        }
    }

    public abstract void ShowInfo();
}