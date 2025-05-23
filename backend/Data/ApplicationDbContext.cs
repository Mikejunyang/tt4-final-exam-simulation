using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {         

        }
        public DbSet<Task> Tasks { get; set; }
    }

}