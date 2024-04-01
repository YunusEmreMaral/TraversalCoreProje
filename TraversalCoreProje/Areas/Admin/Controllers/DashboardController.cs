<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
=======
﻿using Microsoft.AspNetCore.Mvc;
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
<<<<<<< HEAD
    [Authorize(Roles = "Admin")]

=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
