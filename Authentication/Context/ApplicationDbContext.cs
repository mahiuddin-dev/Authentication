using Authentication.Models;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserAuthentication> userAuthentications { get; set; }
    }
}
