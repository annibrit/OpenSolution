using Open.Archetypes.RoleClasses;
namespace Open.Archetypes.BaseClasses {
    public class Entity : BaseEntity<EntityType> {
        public override EntityType Type => EntityTypes.Find(TypeId);
        public Roles Roles => Roles.GetPerformerRoles(UniqueId);
        //NB: Selle järgi igale klassile 1 - 0...* seose näitamiseks
        public static Entity Random() {
            var e = new Entity();
            e.SetRandomValues();
            return e;
        }
    }
}
