using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NkatmanliOrnekleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen isminizi giriniz : ");
            string isim = Console.ReadLine();

            Console.Write("Lütfen soyisminizi giriniz : ");
            string soyisim = Console.ReadLine();

            Console.Write("Lütfen ID numaranızı giriniz : ");
            int ID = Convert.ToInt32(Console.ReadLine());

            BusinessLogicLayer BLL = new BusinessLogicLayer();
            int EKS = BLL.VeriKaydet(ID, isim, soyisim);

            if (EKS > 0)
            {
                Console.WriteLine("İşlem BAŞARILI !");
            }
            else
            {
                Console.WriteLine("İşlem BAŞARISIZ !");
            }

            Console.ReadLine();
        }
    }
}
