using System;
namespace CHUYENDOITIENTE
{
    class DoiTuUSDsangVND
    {
        static void Main(string[] args)
        {
            int rate = 23000;
            float usd;
            Console.Write("$");
            usd = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} USD = {1} VND", usd, usd*rate);
        }
    }
}