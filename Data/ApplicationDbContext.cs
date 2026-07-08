using Microsoft.EntityFrameworkCore;
using StudentMvcApp.Models;

namespace StudentMvcApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
    }
}
