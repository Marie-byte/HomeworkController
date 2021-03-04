using System.ComponentModel.DataAnnotations;

namespace Homework.Models
{
    public class Studentdescription
    {
        [Key]
        public int Id{get;set;}
        public int Students_id{get;set;}
        public int Age{get;set;}
        public string First_name{get;set;}
        public string Last_name{get;set;}
        public string Address{get;set;}
        public string Country{get;set;}
    }
}