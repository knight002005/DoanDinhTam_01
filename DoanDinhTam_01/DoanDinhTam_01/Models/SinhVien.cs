using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoanDinhTam_01.Models
{
    public class SinhVien
    {
        [Key]
        public int MaSinhVien { get; set; } 
        public string Hoten { get; set; }

        [ForeignKey("Malop")]
        public virtual LopHoc LopHocs { get; set; }
        public int Malop { get; set; }
    }
}