using Microsoft.EntityFrameworkCore;
using MyApi.Models;

namespace MyApi.Data
{
    public class KeyValueAPIDbContext : DbContext
    {
        protected KeyValueAPIDbContext(DbContextOptions options):base(options) 
        {
        }
        public DbSet<KeyValue> keyValues { get; set; }
    }
}
