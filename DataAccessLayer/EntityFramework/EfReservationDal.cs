using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal:GenericRepository<Reservation> , IReservationDal
    {
<<<<<<< HEAD
        Context context = new Context();

        public void ChangeToFalseByGuide(int id)
        {
            var values = context.Reservations.Find(id);
            values.Status = "Onay Bekliyor";
            context.SaveChanges();
        }

        public void ChangeToTrueByGuide(int id)
        {
            var values = context.Reservations.Find(id);
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserID == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserID == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onay Bekliyor" && x.AppUserID == id).ToList();
            }
        }
<<<<<<< HEAD
        public List<Reservation> GetReservationWithUserandDestination()
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Include(x=>x.AppUser).ToList();
            }
        }
=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
    }
}
