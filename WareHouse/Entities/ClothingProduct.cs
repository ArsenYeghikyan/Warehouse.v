using WareHouse.Enums;

namespace WareHouse.Entities
{
    public class ClothingProduct : BaseProduct
    {
        public Size Size { get; private set; }
        public Category Category { get; private set; }
        public Color Color { get; private set; }
        public Gender Gender { get; private set; }
        public Season Season { get; private set; }


        public ClothingProduct(int id, string name, int quantity) : base(id, name, quantity) // TODO add new field in constractor
        {

        }


    }
}
