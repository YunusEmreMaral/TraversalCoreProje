﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guide
    {
        [Key]
        public int GuideID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string TwitterUrl { get; set; }
<<<<<<< HEAD
        public string Description2 { get; set; }

        public string ınstagramUrl { get; set; }
        public bool Status { get; set; }
        public List<Destination> Destinations { get; set; }
=======
        public string ınstagramUrl { get; set; }
        public bool Status { get; set; }
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
    }
}
