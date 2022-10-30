using FurnitureFactoryDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace FurnitureFactoryDatabaseImplement
{
    public class FurnitureFactoryDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-EEIRHLB\SQLEXPRESS;Database=lab3;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Supplier> Suppliers { set; get; }
        public virtual DbSet<OrganizationType> OrganizationTypes { set; get; }
    }
}

