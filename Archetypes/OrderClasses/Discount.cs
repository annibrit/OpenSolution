using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.OrderClasses
{
    public class Discount : Archetype
    {
        private string reason;

        public static Discount Random()
        {
            var x = new Discount();
            x.SetRandomValues();
            return x;
        }
        
        // Alati, kui on Random ja klassis on privaatsed 
        // muutujad tuleb need SetRandomValues meetodis väärtustada
        protected override void SetRandomValues()
        {
            base.SetRandomValues();
            reason = GetRandom.String();
        }

        public string Reason
        {
            get { return SetDefault(ref reason); }
            set { SetValue(ref reason, value); }
        }
    } 
}