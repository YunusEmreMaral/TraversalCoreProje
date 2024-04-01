using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
<<<<<<< HEAD
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
=======
using Microsoft.AspNetCore.Mvc;
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {

        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
<<<<<<< HEAD
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

<<<<<<< HEAD
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.DestinationID = id;

            

            var values = destinationManager.TGetDestinationWithGuide(id);
=======
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.DestinationID = id;
            var values = destinationManager.TGetByID(id);
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }
    }
}
