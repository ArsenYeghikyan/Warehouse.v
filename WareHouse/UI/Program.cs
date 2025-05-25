using WareHouse.Entities;

namespace WareHouse.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseProduct prod = new ClothingProduct(12,"hh",21);
            BaseWarehouse wareHouse = new ClothingWarehouse();
            wareHouse.AddProduct(prod);
        }
    }
}
