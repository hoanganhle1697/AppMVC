using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSP { get; set; } // Tên sản phẩm

        [Required]
        [StringLength(100)]
        public string Slug { get; set; } // Slug dùng cho SEO-friendly URL

        [Required]
        [Range(0, double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Gia { get; set; } // Giá sản phẩm

        [StringLength(500)]
        public string MoTa { get; set; } // Mô tả sản phẩm

        [StringLength(255)]
        public string HinhAnh { get; set; } // Đường dẫn hình ảnh

        [ForeignKey("Category")]
        public int CategoryID { get; set; } // FK đến Danh mục sản phẩm

        // Điều hướng tới Danh mục
        public virtual Category Category { get; set; }
    }
}
