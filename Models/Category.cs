using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDanhMuc { get; set; }

        // Điều hướng tới các sản phẩm trong danh mục này
        public virtual ICollection<Product> Categories { get; set; }
    }
}
