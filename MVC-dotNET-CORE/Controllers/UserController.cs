using Microsoft.AspNetCore.Mvc;
using MVC_dotNET_CORE.Models;
using System.ComponentModel;

namespace MVC_dotNET_CORE.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<ModelUser> lista = new List<ModelUser>();
            using (var db = new Models.DB.CContext())
            {
                lista = (from x in db.Students
                         select new ModelUser()
                         {
                             Nombre = x.Name,
                             Edad = -1
                         }).ToList();
            }
            return View(lista);
        }

    }
}
