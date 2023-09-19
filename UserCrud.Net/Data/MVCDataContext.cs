using Microsoft.EntityFrameworkCore;
using UserCRUD.Models.Domain;

namespace UserCRUD.Data
{
    public class MVCDataContext : DbContext

    {
        public MVCDataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
