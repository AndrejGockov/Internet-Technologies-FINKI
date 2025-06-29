using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_2_Group_B.Models
{
    public class EventModel
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        [Required]
        public string location { get; set; }
    }
}