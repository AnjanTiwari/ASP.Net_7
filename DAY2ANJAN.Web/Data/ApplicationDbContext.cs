using Microsoft.EntityFrameworkCore;
using DAY2ANJAN.Web.Models;
namespace DAY2ANJAN.Web.Data{
    public class ApplicationDbContext : DbContext{

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<People> Peoples { get; set; }
        
    }
}

