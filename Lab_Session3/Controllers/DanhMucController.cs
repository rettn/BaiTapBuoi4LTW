using Lab_Session3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_Session3.Controllers
{
    public class DanhMucController : Controller
    {
        protected DanhMuc danhmucs = new DanhMuc();
        public PartialViewResult DanhMuc()
        {
            var danhmuc = danhmucs.GetDanhMucs();
            return PartialView(danhmuc);
        }
    }
}
