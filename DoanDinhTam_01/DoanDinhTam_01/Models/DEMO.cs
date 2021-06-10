using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoanDinhTam_01.Models
{
    public class DEMO
    {
        [Key]
        public int id { get; set; }
        public int NAME { get; set; }
    }
}