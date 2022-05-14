using ApiArquiteturaDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiArquiteturaDDD.Data.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
