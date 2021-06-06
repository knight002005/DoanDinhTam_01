using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoanDinhTam_01.Models
{
   
    public class LopHoc
    {
        [Key]
        public int Malop { get; set; }
        public string TenLop { get; set; }
          
    }
}