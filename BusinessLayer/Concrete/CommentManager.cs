﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public List<Comment> TGetListWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }
        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public Comment TGetByID(int id)
        {
            return _commentDal.GetByID(id);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetList();
        }

        public List<Comment> TGetDestinationById(int id)
        {
            return _commentDal.GetListByFilter(x => x.DestinationID.Equals(id)); // ÖNEMLİ
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
<<<<<<< HEAD
        public List<Comment> TGetListCommentWithDestinationAndUser(int id)
        {
            return _commentDal.GetListCommentWithDestinationAndUser(id);
        }

        public List<Comment> TGetListUserComments(int id)
        {
            return _commentDal.GetListUserComments(id);
        }
=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
    }
}
