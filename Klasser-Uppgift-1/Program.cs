using Klasser_Uppgift_1;
using System;
using System.Runtime.InteropServices;

namespace Uppgift1
{
    class Program
    {
        static void Main()
        {
            Klass1 bil = new();

            bil.setMärke = "Volvo";
            bil.setModell = "V70";
            bil.setVikt = "1 ton";
            bil.setFärg = "röd";
            bil.setHästkraft = 500;

            Console.WriteLine(bil.setMärke);
            Console.WriteLine(bil.setModell);
            Console.WriteLine(bil.setVikt);
            Console.WriteLine(bil.setFärg);
            Console.WriteLine(bil.setHästkraft);

        }
    }
}