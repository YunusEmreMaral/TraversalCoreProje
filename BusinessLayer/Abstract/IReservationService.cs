using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstarct
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
        List<Reservation> GetListWithReservationByWaitApproval(int id);
<<<<<<< HEAD
        List<Reservation> TGetReservationWithUserandDestination();
        void TChangeToTrueByGuide(int id);
        void TChangeToFalseByGuide(int id);

=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

    }
}
