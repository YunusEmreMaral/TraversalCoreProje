using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        AboutManager am = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var values = am.TGetList().FirstOrDefault();

            return View(values);
        }
    }
}
