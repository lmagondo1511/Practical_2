using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_2.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group
        public ActionResult People()
        {
            List<Models.StudyGroup> people = new List<Models.StudyGroup>();

            people.Add(new Models.StudyGroup { studentNumber = "u24735427", name = "Lesedi", surname = "Magondo", emailAddress = "u24735427@tuks.co.za", myLink = "~/HTML/Person01.html" });
            people.Add(new Models.StudyGroup { studentNumber = "u22585762", name = "Ashleigh", surname = "Hulett", emailAddress = "u22585762@tuks.co.za" , myLink = "~/HTML/Person02.html" });
            people.Add(new Models.StudyGroup { studentNumber = "u24719872", name = "Khanyisile", surname = "Mazibuko", emailAddress = "u24719872@tuks.co.za" , myLink = "~/HTML/Person03.html" });
            people.Add(new Models.StudyGroup { studentNumber = "u24829839", name = "Ntsika", surname = "Mazamisa", emailAddress = "u24829839@tuks.co.za" , myLink = "~/HTML/Person04.html" });
            people.Add(new Models.StudyGroup { studentNumber = "u24652777", name = "Unathi", surname = "Ledwaba", emailAddress = "u24652777@tuks.co.za" , myLink = "~/HTML/Person05.html" });

            return View(people);
        }
    }
}