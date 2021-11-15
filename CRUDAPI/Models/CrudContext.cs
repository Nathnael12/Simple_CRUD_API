

using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Models
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options): base(options){}
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
