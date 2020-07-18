using System;
using System.Collections.Generic;
using System.Text;

namespace BangunDatar
{
    public class Lingkaran
    {
        public interface OnResult
        {
            void OnSucceed(double result);
        }
        OnResult viewListener;

        public Lingkaran(OnResult viewListener)
        {
            this.viewListener = viewListener;
        }

        public void LuasLingkaran()
        {
            Console.WriteLine("Menghitung Luas Lingkaran");
            Console.Write("Masukkan Jari-jari : ");
            float jari = float.Parse(Console.ReadLine());

            double result = 3.14 * jari * jari;
            Console.Write("Luas Segitiga Adalah : ");
            this.viewListener.OnSucceed(result);
        }

    }
}
