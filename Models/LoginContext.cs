using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class LoginContext : DbContext

    {
        public LoginContext()
        {
        }
        public LoginContext(DbContextOptions<LoginContext> options)
            : base(options)
        {
        }

        public DbSet<LoginItem> LoginItems { get; set; }
    }
}
