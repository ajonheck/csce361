﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RoomQuery.Models
{
    public class Professor
    {
        [Key]
        public int ProfessorID { get; }
        [Index(IsUnique = true)]
        public int Nuid { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public int PassHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}