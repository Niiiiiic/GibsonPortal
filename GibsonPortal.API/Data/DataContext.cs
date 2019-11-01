using Microsoft.EntityFrameworkCore;
using GibsonPortal.API.Models;

namespace GibsonPortal.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
        public DbSet<Value> Values { get; set; }
        
    }
}