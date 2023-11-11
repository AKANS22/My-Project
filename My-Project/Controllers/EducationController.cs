﻿using Ezeji_Udoka_Akans.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ezeji_Udoka_Akans.Controllers
{
    public class EducationController : Controller
    {
        public IActionResult Index()
        {
            var education = new List<EducationModel>
        {
            new EducationModel
            {
                SchoolName = "SCRUMstudy",
                Certificate = "Scrum Fundamentals Certified, SCRUM Methodologies",
                DateTime =     "Oct 2022 - Nov 2022 ",

                Description = "Scrum Fundamentals Certified (SFC®) professionals are facilitators who ensure that the Scrum Team is provided with an environment conducive to completing the project successfully. The Scrum Master guides, facilitates, and teaches Scrum practices to everyone involved in the project; clears impediments for the team and ensures that Scrum processes are being followed."

            },

             new EducationModel
            {
                SchoolName = "Imo State University",
                Certificate = "B.Sc.INDUSTRIAL CHEMISTRY",
                DateTime =     "2012 - 2016",

                Description = ""

            },

              new EducationModel
            {
                SchoolName = "UNIQUE COMPUTER INSTITUTE OWERRI",
                Certificate = "CERTIFICATE IN COMPUTER APPLICATION TO BUSINESS TRANSACTION",
                DateTime =     "2012 - 2012 ",

                Description = "Computer Application in Business is a course designed to train student on\r\nthe use of personal computer in the world of business. The knowledge gained in this course would lead to proficiency in electronic business management."
            },
        };


            return View(education);
        }
    }
}

