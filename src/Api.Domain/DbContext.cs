using System.Data.Entity;

namespace Api.Domain
{
    public class DatabaseContext : DbContext
    {
        static DatabaseContext()
		{
            Database.SetInitializer<DatabaseContext>(null);
		}

        public DatabaseContext(): base("name=DatabaseEntities")
        {
        }
        
        public DbSet<Foo> Foos { get; set; }
    }
}