using api_demo.Models;
using Microsoft.EntityFrameworkCore;

namespace api_demo.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<SanPham> SanPham { get; set; }
    }
}
