using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Entities
{
    public interface IWarehouse
    {
        BaseProduct[] AddProduct(BaseProduct product);
        BaseProduct[] RemoveProduct(int productId);
        BaseProduct[] UpdateQuantity(int productID, int quantity);
        BaseProduct[] GetAllProducts();
        BaseProduct SearchProduct(int id);
        BaseProduct SearchProduct(int id, string Name);
    }

}
