namespace Open.Aids
{
    public static class Str
    {
        public static string EmptyIfNull(string s)
        {
            return string.IsNullOrEmpty(s) ? string.Empty : s;
        }
    }
}