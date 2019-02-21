using Microsoft.EntityFrameworkCore;
using WishList.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WishList.Data
{
    public class ApplicationDbContext : IdentifyDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.Item> Items { get; set; }
    }
}
