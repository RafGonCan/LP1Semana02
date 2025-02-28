using System;
using System.Reflection;

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

            //Declare overflow uint
            uint m = uint.MaxValue;
            Console.WriteLine((uint)(m+1));

            //Declare overflow float
            float n = 2 * float.MaxValue;
            float o = float.MaxValue + 1;
            
            //show overflows
            Console.WriteLine(n);
            Console.WriteLine(o);

            //Declare underflow
            float p, q;
            p = q = 1000000.0f;
            
            //show underflow
            Console.WriteLine(p == q + 0.0000001f);
        }
    }
}
