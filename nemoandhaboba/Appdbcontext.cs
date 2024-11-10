using Microsoft.EntityFrameworkCore;
using nemoandhaboba.models;

namespace nemoandhaboba
{
    public class Appdbcontext:DbContext

    {
       public Appdbcontext(DbContextOptions<Appdbcontext>options):base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }    
    }
}
