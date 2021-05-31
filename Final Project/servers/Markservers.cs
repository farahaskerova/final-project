 using Final_Project.EachSale;
using Final_Project.IMarkatable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.servers
{
    class Markservers : marktable
    {
        public List<ProductInfo> Products { get; private set; }
        public List<SaleInfo> Sale { get; private set; }
        List<ProductInfo> marktable.Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<SaleInfo> marktable.Sale { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddNewProducts(string Name, double Price, int Count, Categories categories)
        {
            if (string.IsNullOrEmpty(Name)) 
            {
                throw new ArgumentNullException("Name");
            }

            if (Price<=0)
            {
                throw new ArgumentOutOfRangeException("price");
            }

            if (true)
            {

            }
        }

        public void AddNewProducts(string Name, double Price, int Count)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name");
            }

            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("price");
            }
        }

        public void AddSales(int No)
        {
            int index = Sale.FindIndex(d => d.No == No);

            if (index == -1)
                throw new KeyNotFoundException();
        }

        public void AllProductsInfo(int Code, string Name, Enum Categories, int Count, double Price)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name");
            }

            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("price");
            }
        }

        public void AllProductsInfo(string Code, string Name, Enum Categories, int Count, double Price)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name");
            }

            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("price");
            }
        }

        public void AllSalesInfo(int No, double Price, int Count, DateTime Date)
        {
            int index = Sale.FindIndex(d => d.No == No);

            if (index == -1)
                throw new KeyNotFoundException();

            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("price");
            }           
        }

        public void EditProducts(string Code)
        {
            if (string.IsNullOrEmpty(Code))
            {
                throw new ArgumentNullException("Code");
            }
        }

        public void FullReturnOfSales()
        {
            throw new NotImplementedException();
        }

        public void Productss()
        {
            throw new NotImplementedException();
        }

        public void DeleteProducts(string Code)
        {
            if (string.IsNullOrEmpty(Code))
            {
                throw new ArgumentNullException("Code");
            }
        }

        public void DeleteSales(int No)
        {
            int index = Sale.FindIndex(d => d.No == No);

            if (index == -1)
                throw new KeyNotFoundException();
        }

        public List<SaleInfo> ReturnOfSalesByDateRange(DateTime start, DateTime end)
        {
            //List<SaleInfo> sale = _sale.FindAll(s => 0 S.saleDate >= start && s.saleDate <= end);

            return Sale;
        }

        public void ReturnSalesForDate(int No, double Price, int Count, DateTime Date)
        {
            int index = Sale.FindIndex(d => d.No == No);

            if (index == -1)
                throw new KeyNotFoundException();

            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("price");
            }   
             
        }


        public void ReturnProductsByCategories(string Code, string Name, Enum Categories, int Count, double Price)
        {
            if (string.IsNullOrEmpty(Code))
            {
                throw new ArgumentNullException("Code");
            }

            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name");
            }

            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("Price");
            }

            if (Count<=0)
            {
                throw new ArgumentOutOfRangeException("Count");
            }
        }

        public void ReturnProductsByPriceRange(string Code, string Name, Enum Categories, int Count, double Price)
        {
            if (string.IsNullOrEmpty(Code))
            {
                throw new ArgumentNullException("Code");
            }

            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name");
            }

            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("price");
            }

            if (Count <= 0)
            {
                throw new ArgumentOutOfRangeException("Count");
            }
        }

        public void ReturnProductFronSales(int SalesNo, int CodeProducts, int ReturnCount)
        {
            if (SalesNo<=0)
            {
                throw new ArgumentOutOfRangeException("SalesNo");
            }

            if (CodeProducts<=0)
            {
                throw new ArgumentOutOfRangeException("CodeProducts");
            }

            if (ReturnCount<=0)
            {
                throw new ArgumentOutOfRangeException("ReturnCount");
            }
            //SaleInfo saleinfo = _sale.Find(s <= s.No.Sales == SalesNo);

            if (Sale == null)
            {
                throw new ArgumentNullException();
            }
            //SaleItems saleItems = _sale.SaleItems.Find(si <= si.Products.Code == CodeProducts);

            if (Products == null)
            {
                throw new ArgumentNullException();
            }
        }

        public void ReturnSalesByNumber(int No, double Price, int Count, DateTime Date, string Product, string count, string Name, int no)
        {
            int index = Sale.FindIndex(d => d.No == No);

            if (index == -1)
                throw new KeyNotFoundException();

            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name");
            }

            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("price");
            }

            if (Count <= 0)
            {
                throw new ArgumentOutOfRangeException("Count");
            }

            int Index = Sale.FindIndex(d => d.No == no);

            if (index == -1)
                throw new KeyNotFoundException();
        }

        public void ReturnSalesByPrice()
        {
            throw new NotImplementedException();
        }

        public void Sales()
        {
            throw new NotImplementedException();
        }

        public void SearchProductsByName(string Code, string Name, Enum Categories, int Count, double Price)
        {
            if (string.IsNullOrEmpty(Code))
            {
                throw new ArgumentNullException("Code");
            }
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentNullException("Name");
            }

            if (Count <= 0)
            {
                throw new ArgumentOutOfRangeException("Count");
            }

            if (Price <= 0)
            {
                throw new ArgumentOutOfRangeException("price");
            }
        }

        void marktable.ReturnOfSalesByDateRange(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
    }
}