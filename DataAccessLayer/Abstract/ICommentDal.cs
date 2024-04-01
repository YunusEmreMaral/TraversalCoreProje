using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICommentDal:IGenericDal<Comment>
    {
        public List<Comment> GetListCommentWithDestination();
<<<<<<< HEAD
        public List<Comment> GetListCommentWithDestinationAndUser(int id);
        public List<Comment> GetListUserComments(int id);
=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

    }
}
