using System;

namespace Open.Aids
{
    public class Rnd
    {
        private static readonly Random rnd = new Random();

        public static int Integer(int min = int.MinValue, int max = int.MaxValue)
        {
            return min < max ? rnd.Next(min, max) : rnd.Next(max, min);
        }

        public static char Char()
        {
            return (char) rnd.Next('A', 'Z' - 1);
        }

        public static string String(byte min = 1, byte max = byte.MaxValue)
        {
            min = min < 1 ? (byte) 1 : min;
            var c = new char[Integer(min, max)];
            for (var i = 0; i < c.Length; i++) c[i] = Char();
            return new string(c);
        }

        public static double Double(double min = double.MinValue,
            double max = double.MaxValue)
        {
            var d = rnd.NextDouble() * (max - min) + min;
            return double.IsInfinity(d) ? Integer() : d;
        }
    }
}