using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame.Models
{
    public class PersonModel
    {
        [Key]         
        public int id { get; set; } 
        [MaxLength(255)]

        public string name { get; set; } 
        [MaxLength(255)]

        public string phone_number { get; set; } 
        [MaxLength(255)]

        public string city { get; set; } 
        

        public PersonModel(string name, string phone_number, string city)
        {
            this.name = name;
            this.phone_number = phone_number;
            this.city = city;
        }

        public PersonModel()
        {
        }
    }
}
