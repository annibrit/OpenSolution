using System.Collections.Generic;
using System.Linq;
using Open.Aids;

namespace Open.Archetypes.BaseClasses
{
    public class Strings : Archetypes<string>
    {
        public string Content
        {
            get
            {
                var s = this.Aggregate(string.Empty, (x, e) => x + " " + e);
                return s.Trim();
            }
        }

        public static Strings Random()
        {
            var s = new Strings();
            var count = GetRandom.Int8(0);
            for (var i = 0; i < count; i++)
                s.Add(GetRandom.String());
            return s;
        }

        public static IEnumerable<string> ToList(string s, char separactor = ' ')
        {
            var l = new Strings();
            AddHead(l, s, separactor);
            return l;
        }

        private static void AddHead(Strings l, string s, char separactor = ' ')
        {
            if (string.IsNullOrWhiteSpace(s)) return;
            var head = GetString.Head(s, separactor);
            l.Add(head);
            AddHead(l, s.Replace(head, string.Empty).Trim());
        }
    }
}