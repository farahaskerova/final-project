using System;
using System.Text;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;

            do

            {
                //Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine(" ");
                Console.WriteLine("1.Carry out operations on products");// Mehsullar uzerinde emeliyyat aparmaq
                Console.WriteLine(" ");
                Console.WriteLine("2.Carry out operations on sales");//Satislar uzerinde emeliyyat aparmaq
                Console.WriteLine(" ");
                Console.WriteLine("3. Log out");//Sistemden cixmaq
                Console.WriteLine(" ");               
                Console.WriteLine("Please choose  your option");


                string selectionStr = Console.ReadLine();
                selection = int.Parse(selectionStr);

                switch (selection)
                {
                    case 1:
                        MenuServer.AddMenuProducts();
                        break;
                    case 2:
                        //Mehsul uzerinde duzelis et -duzelis edilecek mehsulun cod
                        break;
                    case 3:
                        //Mehsulu sil
                        break;
                    case 4:
                        //Butun mehsullari goster
                        break;
                    case 5:
                        //Categoriyasina gore mehsullari goster
                        break;
                    case 6:
                        //Qiymet araligina gore mehsullari goster
                        break;
                    case 7:
                        //Mehsullar arasinda ada gore axtaris et
                        break;
                    default:

                        break;
                }
            } while (selection != 0);
        }

           

            
        
    }
}
