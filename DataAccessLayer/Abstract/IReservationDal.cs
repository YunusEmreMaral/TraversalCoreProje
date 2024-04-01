using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal:IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitApproval(int id);
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
<<<<<<< HEAD
        List<Reservation> GetReservationWithUserandDestination();

        public void ChangeToTrueByGuide(int id);
        public void ChangeToFalseByGuide(int id);
=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

    }
}
