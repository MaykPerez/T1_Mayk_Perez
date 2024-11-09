using Microsoft.AspNetCore.Mvc;
using T1_Perez_Mayk.Datos;
using T1_Perez_Mayk.Models;

namespace T1_Perez_Mayk.Controllers
{
    public class DistribuidorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DistribuidorController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Distribuidor> lista = _db.Distribuidor;
            return View();
        }
    }
}
