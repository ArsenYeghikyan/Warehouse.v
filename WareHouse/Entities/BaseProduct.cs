namespace WareHouse.Entities;

public class BaseProduct : IProduct
{
    public int Id { get; private set; }
    public string Name { get; protected set; }
    public int Quantity { get; protected set; }
    public BaseProduct(int id, string name, int quantity)
    {


        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException();
        }
        if (quantity <= 0 || id<=0)
        {
            throw new ArgumentException("Quantity or Id cannot be negative or 0");
        }
        Id = id;
        Name = name;
        Quantity = quantity;

    }

 
}
