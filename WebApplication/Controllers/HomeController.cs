using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public JsonResult Save(Customer customer)
        //{
        //    DBContext context = new DBContext();
        //    context.Save(customer);
        //    return null;
        //}
    }
}