using Microsoft.EntityFrameworkCore;

namespace Baitap6
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sửa kết nối chỉ định đúng Server .\SQLEXPRESS
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Database=QuanLySinhVien;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}