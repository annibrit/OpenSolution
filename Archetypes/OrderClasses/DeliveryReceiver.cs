using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class DeliveryReceiver : OrderLine
    {
       //TODO Kas DeliveryReceiver vajab OrderId'd või on OrderLine kaudu juba seotud Orderiga
        private string order_id;
        private string name;
        private string address;
        private uint mobile_phone;

        public string OrderId
        {
            get { return SetDefault(ref order_id); }
            set { SetValue(ref order_id, value); }
        }
        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value);}
        }
        public string Address
        {
            get { return SetDefault(ref address); }
            set { SetValue(ref address, value); }
        }
        public uint MobilePhone
        {
            get { return SetDefault(ref mobile_phone); }
            set { SetValue(ref mobile_phone, value); }
        }

        public static DeliveryReceiver Random()
        {
            var r = new DeliveryReceiver();
            r.SetRandomValues();
            return r;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            name = GetRandom.String();
            address = GetRandom.String(5,7);
            address += ' ';
            address += GetRandom.UInt32(1, 1000);
            address += ", ";
            address += GetRandom.String(5, 19);
            mobile_phone = GetRandom.UInt32(1111111, 99999999);
        }
    }
}