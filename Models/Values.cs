using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Homework.Models
{
    public class Values
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
