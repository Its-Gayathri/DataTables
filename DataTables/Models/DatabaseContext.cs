using System.Data.Entity;

namespace DataTables.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DBConnection")
        {

        }
        public DbSet<Customers> Customers { get; set; }
    }
}