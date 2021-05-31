using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.EachSale
{
    public class SaleInfo : BaseEntity
    {
        private static int _count = 0;        
        public double Price { get; set; }
        public string SaleItems { get; set; }
        public string Date { get; set; }  
        public SaleItems saleItems { get; set; }

        #region List

        List<SaleItems> Saleithem = new();
        #endregion

        public SaleInfo()
        {
            _count++;

            No = _count;          
        }
    
    }         

    
}
