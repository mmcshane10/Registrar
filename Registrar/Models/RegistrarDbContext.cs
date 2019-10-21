using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Registrar.Models
{
  public class RegistrarContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }

    public RegistrarContext(DbContextOptions options) : base(options) { }
  }
}