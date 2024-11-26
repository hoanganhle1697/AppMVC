using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data
{
    public static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    TenSP = "Laptop Dell Inspiron",
                    Slug = "laptop-dell-inspiron",
                    Gia = 20000000,
                    MoTa = "Laptop Dell hiệu suất cao, phù hợp cho công việc.",
                    HinhAnh = "dell-inspiron.jpg",
                    CategoryID = 1 // ID danh mục liên quan
                },
                new Product
                {
                    Id = 2,
                    TenSP = "Điện Thoại iPhone 14",
                    Slug = "dien-thoai-iphone-14",
                    Gia = 25000000,
                    MoTa = "iPhone 14 với công nghệ camera tiên tiến.",
                    HinhAnh = "iphone-14.jpg",
                    CategoryID = 2
                },
                new Product
                {
                    Id = 3,
                    TenSP = "Smartwatch Samsung Galaxy Watch",
                    Slug = "smartwatch-samsung-galaxy-watch",
                    Gia = 6000000,
                    MoTa = "Đồng hồ thông minh với các tính năng sức khỏe.",
                    HinhAnh = "galaxy-watch.jpg",
                    CategoryID = 3
                },
                new Product
                {
                    Id = 4,
                    TenSP = "Tai Nghe Sony WH-1000XM5",
                    Slug = "tai-nghe-sony-wh-1000xm5",
                    Gia = 8500000,
                    MoTa = "Tai nghe chống ồn cao cấp từ Sony.",
                    HinhAnh = "sony-wh-1000xm5.jpg",
                    CategoryID = 4
                },
                new Product
                {
                    Id = 5,
                    TenSP = "Máy Ảnh Canon EOS R10",
                    Slug = "may-anh-canon-eos-r10",
                    Gia = 32000000,
                    MoTa = "Máy ảnh mirrorless nhỏ gọn, chất lượng cao.",
                    HinhAnh = "canon-eos-r10.jpg",
                    CategoryID = 5
                },
                new Product
                {
                    Id = 6,
                    TenSP = "Tivi LG OLED C3",
                    Slug = "tivi-lg-oled-c3",
                    Gia = 45000000,
                    MoTa = "Tivi OLED với công nghệ hình ảnh vượt trội.",
                    HinhAnh = "lg-oled-c3.jpg",
                    CategoryID = 6
                }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    TenDanhMuc = "Laptop"
                },
                new Category
                {
                    Id = 2,
                    TenDanhMuc = "Điện Thoại"
                },
                new Category
                {
                    Id = 3,
                    TenDanhMuc = "Đồng Hồ Thông Minh"
                },
                new Category
                {
                    Id = 4,
                    TenDanhMuc = "Tai Nghe"
                },
                new Category
                {
                    Id = 5,
                    TenDanhMuc = "Máy Ảnh"
                },
                new Category
                {
                    Id = 6,
                    TenDanhMuc = "Tivi"
                }
            );
        }
    }
}
