using System.Web.Mvc;
using WebApplication.Class;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Save(Customer customer)
        {
            DBContext context = new DBContext();
            context.Save(customer);
            return null;
        }
    }
}