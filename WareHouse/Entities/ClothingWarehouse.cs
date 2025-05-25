using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Enums;

namespace WareHouse.Entities
{
    public class ClothingWarehouse : BaseWarehouse, IClothingWarehouse
    {
        public ClothingProduct SearchProduct(int id, string Name, Category category, Gender gender, Season season, Size size, Color color)
        {
            throw new NotImplementedException();
        }

        public ClothingProduct SearchProduct(Season season)
        {
            throw new NotImplementedException();
        }

        public ClothingProduct SearchProduct(Size size)
        {
            throw new NotImplementedException();
        }

        public ClothingProduct SearchProduct(Category category)
        {
            throw new NotImplementedException();
        }

        public ClothingProduct SearchProduct(Color color)
        {
            throw new NotImplementedException();
        }

        public ClothingProduct SearchProduct(Gender gender)
        {
            throw new NotImplementedException();
        }

        public override BaseProduct[] UpdateQuantity(int productID, int quantity)
        {
            throw new NotImplementedException();
        }
    }

}
