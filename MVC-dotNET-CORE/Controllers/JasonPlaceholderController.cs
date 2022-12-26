using Microsoft.AspNetCore.Mvc;
using MVC_dotNET_CORE.Models.DB;

namespace MVC_dotNET_CORE.Controllers
{
    public class JasonPlaceholderController : Controller
    {
        public IActionResult Index()
        {
            List<JasonPlaceholder> lista = new List<JasonPlaceholder>();
            using(var db = new MVC_dotNET_CORE.Models.DB.CContext())
            {
                lista = (from x in db.JasonPlaceholders
                        select x).ToList();
            }
            return View(lista);
        }
    }
}
