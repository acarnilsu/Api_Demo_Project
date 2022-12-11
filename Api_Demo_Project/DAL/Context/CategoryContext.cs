using Api_Demo_Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api_Demo_Project.DAL.Context
{
    public class CategoryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-O6Q5UAT;database=ApiDb; User Id=sa;Password=1234;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
