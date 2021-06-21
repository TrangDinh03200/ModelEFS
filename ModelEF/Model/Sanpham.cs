﻿namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sanpham")]
    public partial class Sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sanpham()
        {
            Chitietdonhangs = new HashSet<Chitietdonhang>();
        }

        [Key]
        public int Masp { get; set; }

        [StringLength(50)]
        [Display(Name ="Tên Sản Phẩm")]
        public string Tensp { get; set; }
        [Display(Name = "Giá Sản Phẩm")]
        public decimal? Giatien { get; set; }
        [Display(Name = "Số lượng Sản Phẩm")]
        public int? Soluong { get; set; }

        [Column(TypeName = "ntext")]
        public string Mota { get; set; }

        public int? Thesim { get; set; }

        public int? Bonhotrong { get; set; }

        public bool? Sanphammoi { get; set; }

        public int? Ram { get; set; }

        [StringLength(10)]
        public string Anhbia { get; set; }

        [Display(Name = "Loại Hàng")]
        public int? Mahang { get; set; }
      
        public int? Mahdh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }

        public virtual Hangsanxuat Hangsanxuat { get; set; }

        public virtual Hedieuhanh Hedieuhanh { get; set; }
    }
}
