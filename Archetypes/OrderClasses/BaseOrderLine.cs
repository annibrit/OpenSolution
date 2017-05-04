using Open.Aids;
using Open.Archetypes.BaseClasses;
namespace Open.Archetypes.OrderClasses
{
    public class BaseOrderLine: UniqueEntity
    {
        //TODO Mis funk on baseorderlinel?

        private string comment;
        private string description;
        private string order_id;

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

        public static BaseOrderLine Random()
        {
            var i = GetRandom.UInt32()%4;
            if (i == 0) return ChargeLine.Random();
            if (i == 1) return TaxOnLine.Random();
            return OrderLine.Random();
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            comment = GetRandom.String();
            description = GetRandom.String();
            order_id = GetRandom.String();
        }
    }
}
