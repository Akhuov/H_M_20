using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace H_M_20
{
    internal class CurrentValues
    {

        public static double Sum = 11400;
        public static double Won = 1290;
        public static double Rub = 84.25;
        public static double Ten = 448.3;
        public static void ShowSumCurrentValueToDollar()
        {
            Console.WriteLine($@"1$ => {Sum} uzs(Uz)");
        }
        public static void ShowWonCurrentValuesToDollar()
        {
            Console.WriteLine($@"1$ => {Won} won(Kor)");
        }
        public static void ShowRuCurrentValuesToDollar()
        {
            Console.WriteLine($@"1$ => {Rub} rub(Ru)");
        }
        public static void ShowTengeCurrentValuesToDollar()
        {
            Console.WriteLine($@"1$ => {Ten} tenge(Kz)");
        }
    }
}
