using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame.Models
{
    public class CustomerModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string city { get; set; }

        public CustomerModel(int id, string name, string phone, string city)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.city = city;
        }
    }
}
