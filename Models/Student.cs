using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OopMvcApplication.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Major { get; set; } = string.Empty;
        public string Telegram { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public string Email { get; set; } = string.Empty;
        public Student(int id, string name, string major, string telegram = "", DateTime dateOfBirth = default, string email = "") 
        { 
            //Property = Parameter
            Id = id; 
            Name = name; 
            Major = major; 
            Telegram = telegram;
            DateOfBirth = dateOfBirth;
            Email = email;
        }
    }
}