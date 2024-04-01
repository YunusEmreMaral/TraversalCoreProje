using BusinessLayer.Abstarct;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByAccepted(id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByPrevious(id);
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitApproval(id);
        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Insert(t);
        }

<<<<<<< HEAD
        public void TChangeToFalseByGuide(int id)
        {
            _reservationDal.ChangeToFalseByGuide(id);
        }

        public void TChangeToTrueByGuide(int id)
        {
            _reservationDal.ChangeToTrueByGuide(id);
        }

=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
        public void TDelete(Reservation t)
        {
            _reservationDal.Delete(t);
        }

        public Reservation TGetByID(int id)
        {
            return _reservationDal.GetByID(id);
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

<<<<<<< HEAD
        public List<Reservation> TGetReservationWithUserandDestination()
        {
            return _reservationDal.GetReservationWithUserandDestination();
        }

=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);
        }
    }
}
