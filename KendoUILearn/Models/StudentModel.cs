﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace KendoUILearn.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
    public class CustomDBContext:DbContext
    {
        public CustomDBContext():base("CustomDB")
        {

        }
        public DbSet<StudentModel> Students { get; set; }
    }
}