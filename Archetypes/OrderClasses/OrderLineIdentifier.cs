
namespace Order
{
    public class OrderLineIdentifier : UniqueIdentifier
    {
        public int OrderLineId { get; set; }

        //TODO: teiste atribuutidega samamoodi

        //private string orderLineIdentifier;

        //public string OrderLineIdentifier
        //{
        //    get { return SetDefault(ref orderLineIdentifier); }
        //    set { SetValue(ref orderLineIdentifier, value); }
        //} 
    }
}