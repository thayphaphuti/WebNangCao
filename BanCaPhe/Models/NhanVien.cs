﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BanCaPhe.Models
{
    public class NhanVien
    {
        [Key]
        [Display(Name = "Username")]
        [StringLength(15, ErrorMessage = "Username chỉ được 6 - 15 kí tự", MinimumLength = 5)]
        [Required(ErrorMessage = "Username không được trống")]
        public string MaNV { get; set; }
        [Required(ErrorMessage = "Họ và tên không được trống!")]
        [Display(Name = "Họ Và Tên")]
        public string TenNV { get; set; }
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Mật khẩu chỉ được 6 - 30 kí tự")]
        [Required(ErrorMessage = "Mật khẩu không được trống!")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }
        [Phone]
        [StringLength(11, ErrorMessage = "SĐT tối đa 11 kí tự!")]
        public string SDT { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        [DataType(DataType.Password)]
        [Compare("MatKhau", ErrorMessage = "Không khớp với mật khẩu!")]
        public string ConfirmMK { get; set; }
        public string ViTri { get; set; }
        public string Ca { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        
    }
}