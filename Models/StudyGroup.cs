﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical_2.Models
{
	public class StudyGroup
	{
        [Display(Name = "Student Number")]
        public string studentNumber { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Surname")]
        public string surname { get; set; }

        [Display(Name = "Email Address")]
        public string emailAddress { get; set; }


        [Display(Name = "Link to Personal Page")]
        public string myLink { get; set; }
    }
}