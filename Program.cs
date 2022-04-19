using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47DersNesneyeYonelikProgramlamayaGiris
{

    class Insan
    {
        public string isim;
        public int yas;

        public void yurume()
        {
            Console.WriteLine("Yuruyor...");



        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            i1.isim = "Muhammet Murat Pala";
            i1.yas = 26;
            Console.WriteLine(i1.isim + " " + i1.yas);

        }
    }
}
