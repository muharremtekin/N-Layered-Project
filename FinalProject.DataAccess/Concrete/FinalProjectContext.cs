using FinalProject.Entities.Concrete;
using System.Data.Entity;

namespace FinalProject.DataAccess.Concrete
{
    public class FinalProjectContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Branch> Branches { get; set; }

    }
}
