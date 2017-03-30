using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.OrderClasses
{
    public class Order : UniqueEntity
    {
        //internal static Order RandomInherited()
        //{
        //    var i = GetRandom.UInt32();
        //    var c = i % 4;
        //    if (c == 0) return ChargeLine.Random();
        //    if (c == 1) return OrderLine.Random();
        //    if (c == 2) return TaxOnLine.Random();
        //    return OrderStatus.Random();
        //}
        
        public static Order Random()
        {
            var a = new Order();
            a.SetRandomValues();
            return a;
        }
        public virtual string Content => string.Empty;
    }
}
