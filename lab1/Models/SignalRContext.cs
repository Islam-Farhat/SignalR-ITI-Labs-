using Microsoft.EntityFrameworkCore;

namespace lab1.Models
{
    public class SignalRContext:DbContext
    {
        public DbSet<Course> Courses => Set<Course>();

        public SignalRContext(DbContextOptions<SignalRContext> options): base(options)
        {
        }
    }
}
