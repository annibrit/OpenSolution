using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class Discount : Archetype
    {
        private string reason;

        public string Reason
        {
            get { return SetDefault(ref reason); }
            set { SetValue(ref reason, value); }
        }

        public static Discount Random()
        {
            var x = new Discount();
            x.SetRandomValues();
            return x;
        }

        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            reason = GetRandom.String();
        }
    } 
}