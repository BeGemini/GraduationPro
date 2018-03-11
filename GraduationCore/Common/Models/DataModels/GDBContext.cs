using System.Configuration;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace GraduationCore.Common.Models.DataModels
{
    public class GDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"server=localhost;userid=root;pwd=hhl123456;port=3306;database=Graduation;charset=utf8;sslmode=none;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Counties> Counties{get;set;}
    }
}