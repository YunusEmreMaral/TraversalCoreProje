using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using System.Linq;
=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
<<<<<<< HEAD
    [Route("Member/[controller]/[action]")]
=======
    [AllowAnonymous]
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
<<<<<<< HEAD

        public IActionResult GetCitiesSearchByName(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var values = from x in destinationManager.TGetList() select x;

            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(y => y.City.Contains(searchString));
            }

            return View(values.ToList());
        }
=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
    }
}
