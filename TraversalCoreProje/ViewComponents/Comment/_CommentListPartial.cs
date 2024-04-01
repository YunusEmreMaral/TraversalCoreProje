using BusinessLayer.Concrete;
<<<<<<< HEAD
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
=======
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

namespace TraversalCoreProje.ViewComponents.Comment
{
    public class _CommentListPartial : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
<<<<<<< HEAD
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.CommentCount = context.Comments.Where(x => x.DestinationID == id).Count();
            var values = commentManager.TGetListCommentWithDestinationAndUser(id);
=======
        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.TGetDestinationById(id);
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
            return View(values);
        }
    }
}
