using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Televizyon T1 = new Televizyon();
            T1.ekranaYaz("Merhaba");
            Console.WriteLine("******************");
            Urun U1 = new Urun();
            U1.ekranaYaz("Merhaba");
            Console.WriteLine("*******************");
            BaseClass B1 = new BaseClass();
            B1.ekranaYaz("Merhaba");
            Console.ReadKey();
        }
    }
}
