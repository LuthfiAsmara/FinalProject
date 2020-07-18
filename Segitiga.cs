 using System;
using System.Collections.Generic;
using System.Text;

namespace BangunDatar
{
    public class Segitiga
    {
        public interface OnResult
        {
            void OnSucceed(double result);
        }
        OnResult viewListener;

        public Segitiga (OnResult viewListener)
        {
            this.viewListener = viewListener;
        }

        public void LuasSegitiga()
        {
            Console.WriteLine("Menghitung Luas Segitiga");
            Console.Write("Masukkan Panjang Alas : ");
            float alas = float.Parse(Console.ReadLine());
            Console.Write("Masukkan Tinggi : ");
            float tinggi = float.Parse(Console.ReadLine());

            double result = (0.5 * alas) * tinggi;
            Console.Write("Luas Segitiga Adalah : ");
            this.viewListener.OnSucceed(result);
            
        }

    }
}
