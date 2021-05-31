using Final_Project.EachSale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.IMarkatable
{
    interface marktable
    {
        #region Lists
        public List<ProductInfo> Products { get;  set; }
        public List<SaleInfo> Sale { get;  set; }
        #endregion

        #region Product method 
        void Productss();

        void AddNewProducts(string Name, double Price, int Count);

        void AllProductsInfo(string Code, string Name, Enum Categories, int Count, double Price);//kodu,adi,categoriyasi,sayi,qiymeti

        void ReturnProductsByCategories(string Code, string Name, Enum Categories, int Count, double Price);//kodu,adi,categoriyasi,sayi,qiymeti

        void ReturnProductsByPriceRange(string Code, string Name, Enum Categories, int Count, double Price);//kodu,adi,categoriyasi,sayi,qiymeti

        void SearchProductsByName(string Code, string Name, Enum Categories, int Count, double Price);//kodu,adi,categoriyasi,sayi,qiymeti

        void EditProducts(string Code);

        void DeleteProducts(string Code);

        #endregion

        #region Sales method
        void Sales();

        void AddSales(int No);

        void FullReturnOfSales();

        void ReturnOfSalesByDateRange(DateTime start, DateTime end);//nomresi,meblegi,mehsul sayi,tarixi

        void ReturnSalesForDate(int No, double Price, int Count, DateTime Date);//nomresi,meblegi,mehsul sayi,tarixi

        void ReturnSalesByPrice();

        void ReturnSalesByNumber(int No, double Price, int Count, DateTime Date, string Product, string count, string Name, int no );//nomresi,meblegi,mehsul sayi,tarixi, satis itemlari (nomresi,mehsul adi,sayi)

        void ReturnProductFronSales(int SalesNo,int CodeProducts, int ReturnCount); 

        void DeleteSales(int No);

        void AllSalesInfo(int No, double Price, int Count, DateTime Date);//nomresi,meblegi,mehsul sayi,tarixi


        #endregion





    }


}
