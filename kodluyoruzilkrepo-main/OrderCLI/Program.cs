using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCLI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string deneme;
            int yeniKayit = 11;
            int siradaki = 10;
            string[] ogrno = new string[yeniKayit];
            ogrno[0] = "101";
            ogrno[1] = "102";
            ogrno[2] = "103";
            ogrno[3] = "104";
            ogrno[4] = "105";
            ogrno[5] = "106";
            ogrno[6] = "107";
            ogrno[7] = "108";
            ogrno[8] = "109";
            ogrno[9] = "110";

            ///string[] isim = { "Ali", "Veli", "Hasan", "Kemal", "Can", "Ahmet", "Mehmet", "Enis", "Bilal", "Burak" };
            string[] isim = new string[yeniKayit];
            isim[0] = "Ali";
            isim[1] = "Veli";
            isim[2] = "Hasan";
            isim[3] = "Kemal";
            isim[4] = "Can";
            isim[5] = "Ahmet";
            isim[6] = "Mehmet";
            isim[7] = "Enis";
            isim[8] = "Bilal";
            isim[9] = "Burak";
            //string[] telefon = { "111", "222", "333", "444", "555", "666", "777", "888", "999", "1000" };
            string[] telefon = new string[yeniKayit];

            telefon[0] = "111";
            telefon[1] = "222";
            telefon[2] = "333";
            telefon[3] = "444";
            telefon[4] = "555";
            telefon[5] = "666";
            telefon[6] = "777";
            telefon[7] = "888";
            telefon[8] = "999";
            telefon[9] = "1000";
            //string[] mail = { "aaaa@aaa.aa", "bbbbb@bbb.bb", "cccc@ccc.cc", "dddd@ddd.dd", "eeee@eee.ee", "ffff@eee.ee", "gggg@eee.ee", "hhhh@eee.ee", "iiii@eee.ee", "jj@eee.eej" };
            string[] mail = new string[yeniKayit];

            mail[0] = "ali@gmail.com";
            mail[1] = "veli@gmail.com";
            mail[2] = "hasan@gmail.com";
            mail[3] = "kemal@gmail.com";
            mail[4] = "can@gmail.com";
            mail[5] = "ahmet@gmail.com";
            mail[6] = "mehmet@gmail.com";
            mail[7] = "enis@gmail.com";
            mail[8] = "bilal@gmail.com";
            mail[9] = "burak@gmail.com";
        deneme:
            Console.Write("Kişi No'yu girin: ");
            string aranan = Console.ReadLine();
            int no = Array.IndexOf(ogrno, aranan.ToString());
            Console.WriteLine("===========================================================================");

            if (no==-1)
            {
                Console.Write("Kişi Bulunamadı ");
                Console.Write("Lütfen yeni kayıt yapınız ");


                Console.Write("TC No'yu girin: ");
              ogrno[siradaki] =Console.ReadLine();
                Console.Write("Ad Soyad  girin: ");
                isim[siradaki] = Console.ReadLine();
                Console.Write("Telefon  girin: ");
                telefon[siradaki] = Console.ReadLine();
                Console.Write("Mail  girin: ");
                mail[siradaki] = Console.ReadLine();
                Console.Write("Kayıt başarılı");

                siradaki++;
                yeniKayit++;
                Console.Clear();
                Console.Write("Kayıt başarılı");
                goto deneme;

            }
            else
            {
                Console.WriteLine("Aranan Kişi : {0}\tTelefonu: {1}\tE-mail: {2}", isim[no], telefon[no], mail[no]);

            }
            Console.ReadKey();


        }

    }
}
