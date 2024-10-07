using Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class WebContext(DbContextOptions<WebContext> options) : IdentityDbContext<WebUser>(options)
    {
        public DbSet<Merchant> Merchants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
