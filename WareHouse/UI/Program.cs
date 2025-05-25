using WareHouse.Entities;

namespace WareHouse.UI;

internal class Program
{
    static void Main(string[] args)
    {
        BaseProduct abstractProduct = new ClothingProduct("FGF", 12);
        abstractProduct.IncreaseQuantity(5);
        abstractProduct.DecreaseQuantity(11);

    }
}
