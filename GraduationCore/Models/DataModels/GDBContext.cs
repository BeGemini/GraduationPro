using Microsoft.EntityFrameworkCore;

namespace GraduationCore.Models.DataModels
{
    public class GDBContext:DbContext
    {
        public GDBContext(DbContextOptions<GDBContext>options):base(options)
        {
            
        }

        public DbSet<Counties> Counties{get;set;}
    }
}