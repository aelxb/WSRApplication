using Microsoft.EntityFrameworkCore;

namespace WSRApplication
{
    class UsrContext : DbContext
    {
        public DbSet<Usr> User { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Store> Store { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               @"Data Source=DESKTOP-D4676LU\sqlexpress;Initial Catalog=WSR;Integrated Security=True");
        }
    }
}
