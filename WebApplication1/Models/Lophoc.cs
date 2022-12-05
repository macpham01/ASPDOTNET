using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Lophoc
    {
        public string malop { get; set; }
        public string tenlop { get; set; }
        public string giangvien { get; set; }
        public Lophoc()
        {
        }
        public Lophoc(string malop, string tenlop, string giangvien)
        {
            this.malop = malop;
            this.tenlop = tenlop;
            this.giangvien = giangvien;
        }
    }

}