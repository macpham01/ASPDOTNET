using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Truonghoc
    {
        List<Sinhvien> danhsach;
        //Phương thức khởi tạo không tham số tạo danh sách 7 sinh viên ở 4 lớp học
        public Truonghoc()
        {
            danhsach = new List<Sinhvien>();
            danhsach.Add(new Sinhvien("s01", "Nguyễn Vân Anh", 20, "Hà nội", "dh01"));
            danhsach.Add(new Sinhvien("s02", "Hà Long Vân", 19, "Hà nội", "dh02"));
            danhsach.Add(new Sinhvien("s03", "Vũ Văn Doanh", 20, "Thái Bình", "dh02"));
            danhsach.Add(new Sinhvien("s04", "Lê Huy Hoàng", 21, "Hà nam", "dh01"));
            danhsach.Add(new Sinhvien("s05", "Hà Bích Ngọc", 20, "Hải Phòng", "dh03"));
            danhsach.Add(new Sinhvien("s06", "Nguyễn Văn Hùng", 20, "Hà nội", "dh04"));
            danhsach.Add(new Sinhvien("s07", "Hoàng Kim Tiến", 19, "Hà nội", "dh04"));
        }
        //Phương thức lấy ra danh sách 7 sinh viên
        public List<Sinhvien> GetAllStudent()
        {
            return danhsach;
        }
        //Phương thức tạo và trả về 4 lớp học có mã tương ứng mã lớp trong class Sinhvien
        public List<Lophoc> GetAllClass()
        {
            List<Lophoc> li = new List<Lophoc>();
            li.Add(new Lophoc("dh01", "Công nghệ thông tin", "Vân Anh"));
            li.Add(new Lophoc("dh02", "Khoa học máy tính", "Lan Nguyễn"));
            li.Add(new Lophoc("dh03", "Kỹ thuật phần mềm", "Long Vân"));
            li.Add(new Lophoc("dh04", "Hệ thống thông tin", "Bích Hơp"));
            return li;
        }
        //Phương thức lấy ra toàn bộ danh sách sinh viên hoặc lấy theo lớp
        public List<Sinhvien> GetStudentByClass(string malop)
        {
            List<Sinhvien> li = new List<Sinhvien>();
            if (malop != null)
            {
                foreach (var item in danhsach)
                {
                    if (item.malop == malop)
                    {
                        li.Add(item);
                    }
                }
                return li;
            }
            else
                return danhsach; //Nếu không có mã lớp, là danh sách đầy đủ ban đầu
        }
        //Phương thức lấy ra 1 sinh viên theo mã sinh viên
        public Sinhvien GetAStudent(string masv)
        {
            Sinhvien s = new Sinhvien();
            s.masv = masv;
            int tt = danhsach.IndexOf(s);
            return danhsach[tt];
        }
        //Phương thức thêm sinh viên
        public void AddStudent(Sinhvien s)
        {
            danhsach.Add(s);
        }
    }
}