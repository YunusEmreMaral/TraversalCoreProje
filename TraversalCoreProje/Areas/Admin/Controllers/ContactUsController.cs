using BusinessLayer.Abstarct;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            var values = _contactUsService.TGetListContactUsByTrue();
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            var values = _contactUsService.TGetByID(id);
            _contactUsService.TDelete(values);
            return RedirectToAction("/Admin/ContactUs/Index");
        }
        [HttpGet]
        public IActionResult ContactUsDetails(int id)
        {
            var values = _contactUsService.TGetByID(id);
            return View(values);
        }
    }
}