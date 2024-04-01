using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ReservationController : Controller
    {
        ReservationManager _reservationManager = new ReservationManager(new EfReservationDal());

       

        public IActionResult Index()
        {
            var values = _reservationManager.TGetReservationWithUserandDestination();

            
            return View(values);
        }

        public IActionResult ChangeToTrue(int id)
        {
            _reservationManager.TChangeToTrueByGuide(id);
            return RedirectToAction("Reservation", "Admin");
        }

        public IActionResult ChangeToFalse(int id)
        {
            _reservationManager.TChangeToFalseByGuide(id);
            return RedirectToAction("Reservation", "Admin");
        }
    }
}
