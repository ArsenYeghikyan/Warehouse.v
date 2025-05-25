namespace WareHouse.Entities;

public interface IProduct
{
    int Id { get; }
    string Name { get; }
    int Quantity { get; }
}
