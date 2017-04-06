using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.RoleClasses
{
    public class RoleType : BaseType<RoleType>
    {
        public RoleConstraints Constraints => RoleConstraints.GetTypeConstraints(UniqueId);
        public override RoleType Type => RoleTypes.Find(TypeId);

        public static RoleType Random()
        {
            var t = new RoleType();
            t.SetRandomValues();
            return t;
        }
    }
}