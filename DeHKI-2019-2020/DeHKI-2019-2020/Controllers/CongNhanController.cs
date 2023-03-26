using System;
using DeHkI_2019_2020.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeHkI_2019_2020.Controllers
{
	public class CongNhanController : Controller
	{
        public IActionResult Cau3()
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=framework;");
            ViewBag.listDCL = context.getAllDCL();
            return View();
        }

        public IActionResult LietKeCN(string MaDiemCachLy)
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=framework;");
            ViewBag.listCN = context.getCN(MaDiemCachLy);
            return View();
        }

        public IActionResult DeleteCN(string MaCongNhan)
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=framework;");
            int count = context.deleteCN(MaCongNhan);
            ViewData[""] = (count > 0) ? "Xoá thành công" : "Xoá không thành công";
            return View();
        }

        public IActionResult ViewCN(string MaCongNhan)
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=framework;");
            ViewBag.listCN = context.viewCN(MaCongNhan);
            return View();
        }
    }
}

