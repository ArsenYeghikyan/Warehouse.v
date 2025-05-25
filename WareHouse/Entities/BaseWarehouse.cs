using WareHouse.Enums;

namespace WareHouse.Entities
{
    public abstract class BaseWarehouse : IWarehouse
    {


        public BaseProduct[] AddProduct(BaseProduct product)
        {
            throw new NotImplementedException();
        }

        public BaseProduct[] GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public BaseProduct[] RemoveProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public BaseProduct SearchProduct(int id)
        {
            throw new NotImplementedException();
        }

        public BaseProduct SearchProduct(int id, string Name)
        {
            throw new NotImplementedException();
        }

        public abstract BaseProduct[] UpdateQuantity(int productID, int quantity);

        public static implicit operator BaseWarehouse(ClothingProduct v)
        {
            throw new NotImplementedException();
        }
    }
}
