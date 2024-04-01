using AutoMapper;
using BusinessLayer.Abstarct;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.ContactUs;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactUsController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            var validator = new SendContactUsValidator(); 
            var validationResult = validator.Validate(model); 

            if (validationResult.IsValid)
            {
                _contactUsService.TAdd(new ContactUs()
                {
                    Mail = model.Mail,
                    MessageBody = model.MessageBody,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    MessageStatus = true,
                    Name = model.Name,
                    Subject = model.Subject

                });
                return RedirectToAction("Index", "ContactUs");
            }
            return View(model);
        }
    }
}
