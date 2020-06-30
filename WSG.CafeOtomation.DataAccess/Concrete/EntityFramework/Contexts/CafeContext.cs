using Microsoft.EntityFrameworkCore;
using WizardSoftwareGroupsFramework.Core.Entities.Concrete;
using WSG.CafeOtomation.Entities.Concrete;

namespace WSG.CafeOtomation.DataAccess.Concrete.EntityFramework.Contexts
{
    public class CafeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user id=root;Password=Wizard911078;persistsecurityinfo=True;database=cafe");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<UserTitle> UserTitles { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Desk> Desks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<CurrentBook> CurrentBooks { get; set; }
        public DbSet<CurrentBookDetail> CurrentBookDetails { get; set; }
    }
}
