using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web.Data;

namespace Web.Data
{
    public class WebContext(DbContextOptions<WebContext> options) : IdentityDbContext<WebUser>(options)
    {
    }
}
