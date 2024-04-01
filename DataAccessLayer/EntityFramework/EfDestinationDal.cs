using DataAccessLayer.Abstract;
<<<<<<< HEAD
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
=======
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
<<<<<<< HEAD
        public Destination GetDestinationWithGuide(int id)
        {
            using (var c = new Context())
            {
                return c.Destinations.Where(x => x.DestinationID == id).Include(x => x.Guide).FirstOrDefault();
            }
        }

        public List<Destination> GetLast4Destinations()
        {
            using (var c = new Context())
            {
                var values = c.Destinations.Take(4).OrderByDescending(x => x.DestinationID).ToList();
                return values;
            }
        }
=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
    }
}
