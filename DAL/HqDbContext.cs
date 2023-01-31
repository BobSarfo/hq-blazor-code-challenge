using hq_blazor_code_challenge.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace hq_blazor_code_challenge.DAL
{
    public class HqDbContext : DbContext
    {
       
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuthorDb");
        }

        public DbSet<CreditCard> CreditCards { get; set; }
    }
}
