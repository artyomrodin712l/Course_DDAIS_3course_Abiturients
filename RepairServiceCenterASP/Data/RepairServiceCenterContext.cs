using Microsoft.EntityFrameworkCore;
using RepairServiceCenterASP.Models;

namespace RepairServiceCenterASP.Data
{
    public class RepairServiceCenterContext : DbContext
    {
        public RepairServiceCenterContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Post> Posts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<RepairedModel> RepairedModels { get; set; }
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<TypeOfFault> TypeOfFaults { get; set; }
        public DbSet<ServicedStore> ServicedStores { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
