using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //declare variables
            byte a = byte.MaxValue;
            byte aa = byte.MinValue;
            sbyte b = sbyte.MaxValue;
            sbyte bb = sbyte.MinValue;
            short c = short.MaxValue;
            short cc = short.MinValue;
            ushort d = ushort.MaxValue;
            ushort dd = ushort.MinValue;
            int e = int.MaxValue;
            int ee = int.MinValue;
            uint f = uint.MaxValue;
            uint ff = uint.MinValue;
            long g = long.MaxValue;
            long gg = long.MinValue;
            ulong h = ulong.MaxValue;
            ulong hh = ulong.MinValue;
            float i = float.MaxValue;
            float ii = float.MinValue;
            float iii = float.NegativeInfinity;
            float iiii = float.PositiveInfinity;
            float iiiii = float.NaN;
            double j = double.MaxValue;
            double jj = double.MinValue;
            double jjj = double.NegativeInfinity;
            double jjjj = double.PositiveInfinity;
            double jjjjj = double.NaN;
            decimal k = decimal.MaxValue;
            decimal kk = decimal.MinValue;
            char l = char.MaxValue;
            char ll = char.MinValue;

            //show max and min values
            Console.WriteLine($"{a}-{aa}, {b}-{bb}, {c}-{cc}, {d}-{dd}, {e}-{ee}");
            Console.WriteLine($"{f}-{ff}, {g}-{gg}, {h}-{hh}, {i}-{ii}, {j}-{jj}");
            Console.WriteLine($"{k}-{kk}, {l}-{ll}");

            //show special values
            Console.WriteLine($"{iii}, {iiii}, {iiiii}");
            Console.WriteLine($"{jjj}, {jjjj}, {jjjjj}");

            //overflow uint
            uint m = uint.MaxValue;
            Console.WriteLine((uint)(m+1));
        }
    }
}
