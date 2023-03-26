using DeHkI_2019_2020.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeHkI_2019_2020.Controllers
{
	public class DiemCachLyController:Controller
	{
        public IActionResult Cau1()
        {
            return View();
        }

        public IActionResult ThemDCL(DiemCachLy dcl)
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=framework;");
            context.ThemDCL(dcl);
            return View("Cau1");
        }
    }
}

