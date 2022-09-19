using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_Mevsimler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch Case İle Mevsimler Uygulaması");
            Console.WriteLine();
            string mevsim;
            Console.WriteLine("Lütfen Mevsim Giriniz?");
            mevsim = Console.ReadLine();
            switch (mevsim)
            {
                case "yaz": Console.WriteLine("Haziran-Temmuz-Ağustos"); break;
                case "ilkbahar": Console.WriteLine("Mart-Nisan-Mayıs"); break;
                case "sonbahar": Console.WriteLine("Eylül-Ekim-Kasım"); break;
                case "kış": Console.WriteLine("Aralık-Ocak-Şubat"); break;
                default: Console.WriteLine("Girdiğiniz Aralıkta Değer Bulunamadı"); break;
            }
            Console.Read();
        }
    }
}
