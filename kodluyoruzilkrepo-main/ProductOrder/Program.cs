using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product();
        }

        public static void Product()
        {
            //string deneme = string.Empty;
            int newProduct = 11;
            int nextProduct = 10;

            //misafir giris numarası Dizisi
            string[] ProductNo = new string[newProduct];
            ProductNo[0] = "101";
            ProductNo[1] = "102";
            ProductNo[2] = "103";
            ProductNo[3] = "104";
            ProductNo[4] = "105";
            ProductNo[5] = "106";
            ProductNo[6] = "107";
            ProductNo[7] = "108";
            ProductNo[8] = "109";
            ProductNo[9] = "110";



            //misafir adı Dizisi
            ///string[] isim = { "Ali", "Veli", "Hasan", "Kemal", "Can", "Ahmet", "Mehmet", "Enis", "Bilal", "Burak" };
            string[] productName = new string[newProduct];
            productName[0] = "Ali";
            productName[1] = "Veli";
            productName[2] = "Hasan";
            productName[3] = "Kemal";
            productName[4] = "Can";
            productName[5] = "Ahmet";
            productName[6] = "Mehmet";
            productName[7] = "Enis";
            productName[8] = "Bilal";
            productName[9] = "Burak";

            deneme:
            Console.Write("Product No'yu girin: ");
            string wantedRoduct = Console.ReadLine();
            int no = Array.IndexOf(ProductNo, wantedRoduct.ToString());
            Console.WriteLine("===========================================================================");



            //Kayıtlı misafir olmadığın yeni kayıt yeri
            if (no == -1)
            {
                Console.Write("Product Bulunamadı ");



                Console.Write("Yeni Product No yu girin: ");
                productName[nextProduct] = Console.ReadLine();
                Console.Write("Product Adı  girin: ");
                productName[nextProduct] = Console.ReadLine();

                Console.Write("Kayıt başarılı");

                nextProduct++;
                newProduct++;
                Console.Clear();
                Console.Write("Product Kayıt başarılı");
                goto deneme;

            }


            else
            {
                Console.WriteLine("Product Adı : {0}", productName[no]);

            }
            foreach (var user in ProductNo)
            {
                //butun değişkenler burada
                string password = string.Empty;
                double selected, piece, total = 0, amount = 0;
                bool result = true;


                if (wantedRoduct == user)
                {
                    ProductList();

                    while (result)
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Product numarasını giriniz :");
                            selected = Convert.ToDouble(Console.ReadLine());

                            if (selected == 1)
                            {
                                Console.WriteLine("Product adedi giriniz : ");
                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 17000.00;
                                amount = amount + total;
                                result = false;
                                break;

                            }
                            else if (selected == 2)
                            {
                                Console.WriteLine("Product adedi giriniz : ");
                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 5000.00;
                                amount = amount + total;
                                result = false;
                                break;
                            }
                            else if (selected == 3)
                            {
                                Console.WriteLine("Product adedi giriniz: ");
                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 8000.00;
                                amount = amount + total;
                                result = false;
                                break;
                            }
                            else if (selected == 4)
                            {
                                Console.WriteLine("Product adedi giriniz : ");

                                piece = Convert.ToDouble(Console.ReadLine());
                                total = piece * 6500.00;
                                amount = amount + total;


                                result = false;

                                break;
                            }
                        }
                    }
                }
                Console.WriteLine("Product Hesap :" + amount + "£");
                break;
            }

            Console.ReadKey();

        }

        public static void ProductList()
        {

            Console.WriteLine("                   Products List              ");

            Console.WriteLine("                     Product                 ");

            Console.WriteLine("            1-Iphone         - 17000.00          ");

            Console.WriteLine("            2-REDMI          - 5000.00           ");

            Console.WriteLine("            3-Samsung        - 8000.00           ");

            Console.WriteLine("            4-Huawei         - 6500.00           ");




        }

    }


}

