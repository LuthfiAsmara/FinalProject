
using System;

namespace BangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            Segitiga sgtg = new Segitiga(new SegitigaResult());
            Lingkaran lingkar = new Lingkaran(new LingkaranResult());
            Persegi psg = new Persegi(new PersegiResult());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=== Program Menghitung Luas Bangun Datar ===");
            Console.WriteLine(" 1. Lingkaran");
            Console.WriteLine(" 2. Segitiga");
            Console.WriteLine(" 3. Persegi");
            Console.WriteLine(" 4. Keluar");

            Console.Write("Silahkan pilih : ");
            char pilih = char.Parse(Console.ReadLine());

            if (pilih == '1')
            {
                Console.Clear();
                Console.WriteLine();
                lingkar.LuasLingkaran();
            }
            if (pilih == '2')
            {
                Console.Clear();
                Console.WriteLine();
                sgtg.LuasSegitiga();
            }
            if (pilih == '3')
            {
                Console.Clear();
                Console.WriteLine();
                psg.LuasPersegi();
            }
            if (pilih == '4')
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("== Terimakasih :) ==");
                Console.WriteLine();
                Console.WriteLine();
            }




        }

        class SegitigaResult : Segitiga.OnResult
        {
            public void OnSucceed(double result)
            {
                Console.WriteLine(result);
            }
        }

        class LingkaranResult : Lingkaran.OnResult
        {
            public void OnSucceed(double result)
            {
                Console.WriteLine(result);
            }
        }

        class PersegiResult : Persegi.OnResult
        {
            public void OnSucceed(double result)
            {
                Console.WriteLine(result);
            }
        }
    }
}
