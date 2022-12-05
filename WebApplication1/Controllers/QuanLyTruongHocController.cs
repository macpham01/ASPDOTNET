using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class QuanLyTruongHocController : Controller
    {
        Truonghoc th = new Truonghoc();
        // GET: QuanLyTruongHoc
        public ActionResult Index()
        {
            return View("Home/Index");
        }
        public ActionResult CategoryMenu()
        {
            var li = new Truonghoc().GetAllClass();
            return PartialView(li);
        }
        //Trường hợp xem danh sách tất cả sinh viên hoặc xem danh sách sinh viên theo lớp
        [Route("truonghoc/xemds/{malop?}")]
        public ActionResult ViewAllStudents(string malop)
        {
            var li = th.GetStudentByClass(malop);
            return View(li);
        }
        //Trường hợp xem thông tin 1 sinh viên
        [Route("truonghoc/chitietsv/{masv}")]
        public ActionResult ViewAStudent(string masv)
        {
            var s = th.GetAStudent(masv);
            return View(s);
        }
        [HttpGet]
        [Route("truonghoc/nhapsv")]
        public ActionResult InputStudent()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            Truonghoc th = new Truonghoc();
            List<Lophoc> li = th.GetAllClass();
            //Truyền ds lớp học vào SelectListItem để tạo ComboBox khi nhập lớp học sinh viên
            foreach (var item in li)
            {
                items.Add(new SelectListItem { Text = item.tenlop, Value = item.malop });
            }
            ViewBag.lophoc = items;
            return View();
        }
        [HttpPost]
        [Route("truonghoc/output")]
        public ActionResult OutputStudent(Sinhvien s)
        {
            th.AddStudent(s);
            List<Sinhvien> li = th.GetAllStudent();
            return View("ViewAllStudents", li);
            // Chỉ thêm được 1 sinh viên vào danh sách hiện tại.
            // Chưa xử lý để thay đổi danh sách sinh viên
        }

    }
}