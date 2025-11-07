using JokesWebApplication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JokesWebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext <IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<JokesWebApplication.Models.Joke> Joke { get; set; } = default!;
    }
}
