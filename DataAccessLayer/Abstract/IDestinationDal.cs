using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDestinationDal:IGenericDal<Destination>
    {
<<<<<<< HEAD
        public Destination GetDestinationWithGuide(int id);
        public List<Destination> GetLast4Destinations();
=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

    }
}
