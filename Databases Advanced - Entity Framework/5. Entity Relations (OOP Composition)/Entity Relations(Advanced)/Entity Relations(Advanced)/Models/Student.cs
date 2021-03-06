﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Relations_Advanced_.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Course>();
            this.Homeworks = new HashSet<Homework>();
        }
        
        public int Id { get; set; }

        [Required]
        public  string  Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDay { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Homework> Homeworks { get; set; }
    }
}
