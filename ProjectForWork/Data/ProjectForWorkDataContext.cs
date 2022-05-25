using Microsoft.EntityFrameworkCore;
using ProjectForWork.Models;

namespace ProjectForWork.Data
{
    public class ProjectForWorkDataContext : DbContext
    {
        public ProjectForWorkDataContext(DbContextOptions<ProjectForWorkDataContext> options) : base(options) { }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Generation> Generations { get; set; }


    }
}
