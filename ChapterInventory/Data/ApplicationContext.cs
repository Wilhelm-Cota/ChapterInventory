using ChapterInventory.Models;
using Microsoft.EntityFrameworkCore;

namespace ChapterInventory.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<RecordsTamplate> Records { get; set; }
        public DbSet<LoginUser> Users { get; set; }
    }
}
