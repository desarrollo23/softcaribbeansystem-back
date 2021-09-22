using Microsoft.EntityFrameworkCore;
using SoftCaribbeanSystem.Model.Entities;

namespace SoftCaribbeanSystem.Infraestructure.Base.Context
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            :base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Patient> Patient { get; set; }
    }
}
