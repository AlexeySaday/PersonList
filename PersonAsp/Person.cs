using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonAsp
{
    public class Persons
    {
        public int id;
        public string Surname;
        public string Name;
        public string FatherName;
        public string phoneNumber;
        public string address;
        public string description;
        public Persons(int id, string surname, string name,
            string fatherName, string phone, string address, string description)
        {
            this.id = id;
            Surname = surname;
            Name = name;
            FatherName = fatherName;
            phoneNumber = phone;
            this.address = address;
            this.description = description;
        }
        public override string ToString()
        {
            return $"ID: {id} Surname:{Surname} Name:{Name} FatherName:{FatherName} phoneNumber:{phoneNumber}" +
                $"address:{address} description:{description}";
        }
    }
}
