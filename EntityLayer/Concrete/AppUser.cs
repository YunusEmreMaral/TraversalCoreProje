using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int> // asp users tablosuna ek olarak propertyleri buradan ekliyoruz 
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public List<Reservation> Reservations { get; set; }
<<<<<<< HEAD
        public List<Comment> Comments { get; set; }
=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

    }
}
