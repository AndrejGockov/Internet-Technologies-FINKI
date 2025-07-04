﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_3.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Gender Gender { get; set; }
        [Display(Name = "Patient Code")]
        [MinLength(5)]
        [MaxLength(5)]
        public string PatientCode { get; set; }
        public virtual List<Doctor> Doctors { get; set; }
    }
}