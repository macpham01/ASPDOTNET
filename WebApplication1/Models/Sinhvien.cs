using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace WebApplication1.Models
{
    public class Sinhvien
    {
        [DisplayName("Mã sv")]
        public string masv { get; set; }
        [DisplayName("Họ tên")]
        public string hoten { get; set; }
        [DisplayName("Tuổi")]
        public int tuoi { get; set; }
        [DisplayName("Địa chỉ")]
        public string diachi { get; set; }
        [DisplayName("Mã lớp")]
        public string malop { get; set; }
        public Sinhvien()
        {
        }
        public Sinhvien(string masv, string hoten, int tuoi, string diachi, string malop)
        {
            this.masv = masv;
            this.hoten = hoten;
            this.tuoi = tuoi;
            this.diachi = diachi;
            this.malop = malop;
        }
        public override bool Equals(Object obj)
        {
            return this.masv == ((Sinhvien)obj).masv;
        }
    }
}