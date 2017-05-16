
using System.Data.Entity;

namespace Open.Data
{
    public class OrderDatabase : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Entity<OrderViewDal>().ToTable("Orders");
            mb.Entity<OrderDal>().ToTable("Orders");
            base.OnModelCreating(mb);
        }
        public DbSet<OrderViewDal> OrderV { get; set; }
        public DbSet<OrderDal> OrderD { get; set; }
    }
}
