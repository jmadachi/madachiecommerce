using madachiecommerce.EnterpriseBusinessRules.Entities;
using Microsoft.EntityFrameworkCore;

namespace madachiecommerce.InterfaceAdapters.Gateways.DataContexts;
public class madachiecommerceContext: DbContext
{
    public madachiecommerceContext(DbContextOptions<madachiecommerceContext> options): base(options) { }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<OrderHeaderEntity> OrderHeaders { get; set; }
    public DbSet<OrderDetailEntity> OrderDetails { get; set; }
    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<UserEntity> Users { get; set; }
}
