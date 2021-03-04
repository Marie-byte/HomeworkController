using System.ComponentModel.DataAnnotations;

namespace Homework.Models
{
    public class Studentdescription
    {
        [Key]
        public int id{get;set;}
        public int student_id{get;set;}
        public int age{get;set;}
        public string first_name{get;set;}
        public string last_name{get;set;}
        public string address{get;set;}
        public string country{get;set;}
    }
}