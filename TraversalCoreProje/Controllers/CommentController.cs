using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
<<<<<<< HEAD
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
=======
using Microsoft.AspNetCore.Mvc;
using System;
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

namespace TraversalCoreProje.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
<<<<<<< HEAD
        private readonly UserManager<AppUser> _userManager;

        public CommentController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
<<<<<<< HEAD
        public async Task<IActionResult> AddComment(Comment comment)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user != null)
                {
                    comment.AppUserID = user.Id; 
                }
            }

=======
        public IActionResult AddComment(Comment comment)
        {
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.CommentState = true;

            commentManager.TAdd(comment);
<<<<<<< HEAD
            return RedirectToAction("DestinationDetails", "Destination", new { id = comment.DestinationID });
        }

=======
            return RedirectToAction("DestinationDetails", "Destination", new { id = comment.DestinationID }); // bu gönderme dikkat bi bak 
        }
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
    }
}
