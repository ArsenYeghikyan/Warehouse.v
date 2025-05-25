using WareHouse.Enums;

namespace WareHouse.Entities
{
    public interface IClothingWarehouse : IWarehouse
    {

        ClothingProduct SearchProduct(int id, string Name, Category category, Gender gender, Season season, Size size, Color color);
        ClothingProduct SearchProduct(Season season);
        ClothingProduct SearchProduct(Size size);
        ClothingProduct SearchProduct(Category category);
        ClothingProduct SearchProduct(Color color);
        ClothingProduct SearchProduct(Gender gender);

    }
}
