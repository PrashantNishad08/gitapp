using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWepApp.Models
{
    public class Employee
    {
        [Key]
        public int EId { get; set; }
        public string EName { get; set; }
        public string EDesignation { get; set; }
        public DateTime EDOJ { get; set; }
    }
}
