using System.Data.Entity;
using Open.Logic.OrderClasses;

namespace Open.Data
{
    public class DefaultConnection : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Entity<OrderLineViewModel>().ToTable("OrderLines");
            mb.Entity<OrderViewModel>().ToTable("Orders");
            base.OnModelCreating(mb);
        }
        public DbSet<OrderLineViewModel> OrderLines { get; set; }
        public DbSet<OrderViewModel> Orders { get; set; }
    }
}
