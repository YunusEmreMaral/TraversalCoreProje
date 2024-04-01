using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
<<<<<<< HEAD
        public Destination TGetDestinationWithGuide(int id);
        public List<Destination> TGetLast4Destinations();

=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
    }
}
