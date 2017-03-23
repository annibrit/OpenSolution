using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class OrderLines : Archetypes<OrderLine>
    {
        public static OrderLines Instance
        { get; } = new OrderLines();
    }
}
