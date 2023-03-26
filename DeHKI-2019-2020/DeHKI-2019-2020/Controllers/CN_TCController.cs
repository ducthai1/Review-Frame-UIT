using DeHkI_2019_2020.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeHkI_2019_2020.Controllers
{
    public class CN_TCController : Controller
    {
        public IActionResult Cau2()
        {
            return View();
        }

        public IActionResult LietKeTC(int soTC)
        {
            StoreContext context = new StoreContext("server=127.0.0.1;user id=root;password=;port=3306;database=framework;");
            ViewBag.listCNTC = context.LietKeTC(soTC);
            return View();
        }
    }
}
