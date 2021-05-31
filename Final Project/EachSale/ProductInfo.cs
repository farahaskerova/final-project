using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.EachSale
{
    public class ProductInfo : BaseEntity
    {
        #region  Categories
        enum Categories
        {
            Dairy,
            Sweets,
            Meat,
            Flour,
            Drinkables
        }
        #endregion

        private static int _count = 0;
        public double Price { get; set; }
        private int Count { get; set; }//say
        public int Code { get; set; }
        public string categories { get; set; }
        public ProductInfo()
        {
            _count++;

            Count = _count;
        }
    }
}
               
