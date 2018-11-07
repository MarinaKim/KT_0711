namespace KT_0711
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }

        public virtual DbSet<Table_Sales> Table_Sales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
