using JPK_Wysylka.DB.Implementation.Entities;
using Microsoft.EntityFrameworkCore;

namespace JPK_Wysylka.DB.Implementation.Context
{
    public class RequestContext : DbContext
    {
        public DbSet<RequestEntity> Requests { get; set; }

        public RequestContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite()
            base.OnConfiguring(optionsBuilder);
        }
    }
}