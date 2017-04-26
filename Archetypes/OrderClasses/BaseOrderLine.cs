using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.OrderClasses
{
    public class BaseOrderLine: UniqueEntity
    {
        //TODO mis funk on baseorderlinel?

        private string comment;
        private string description;
        private string order_id;

        public static BaseOrderLine Random()
        {
            var x = new BaseOrderLine();
            x.SetRandomValues();
            return x;
        }
        public string OrderId
        {
            get { return SetDefault(ref order_id); }
            set { SetValue(ref order_id, value); }
        }
        
        public string Description
        {
            get { return SetDefault(ref description); }
            set { SetValue(ref description, value); }
        }

        public string Comment
        {
            get { return SetDefault(ref comment); }
            set { SetValue(ref comment, value); }
        }


    }
}
