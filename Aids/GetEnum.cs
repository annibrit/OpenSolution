using System;

namespace Open.Aids
{
    public class GetEnum
    {
        public static int Count<T>()
        {
            return Safe.Run(() =>
            {
                var v = Enum.GetValues(typeof(T));
                return v.Length;
            }, 0);
        }

        public static T Value<T>(int i)
        {
            return Safe.Run(() =>
            {
                var v = Enum.GetValues(typeof(T));
                return (T) v.GetValue(i);
            }, default(T));
        }
    }
}