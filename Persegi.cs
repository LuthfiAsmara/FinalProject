using System;
using System.Collections.Generic;
using System.Text;

namespace BangunDatar
{
    public class Persegi
    {
        public interface OnResult
        {
            void OnSucceed(double result);
        }
        OnResult viewListener;

        public Persegi(OnResult viewListener)
        {
            this.viewListener = viewListener;
        }

        public void LuasPersegi()
        {
            Console.WriteLine("Menghitung Luas Persegi");
            Console.Write("Masukkan Panjang Sisi : ");
            float sisi = float.Parse(Console.ReadLine());

            double result = sisi * sisi;
            Console.Write("Luas Persegi Adalah : ");
            this.viewListener.OnSucceed(result);
        }

    }
}
