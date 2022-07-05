using System;
using System.Collections.Generic;
using System.Text;

namespace PersonList
{
    class Person
    {
        public int id;
        public string Surname;
        public string Name;
        public string FatherName;
        public string phoneNumber;
        public string address;
        public string description;
        public Person(int id,string surname,string name, 
            string fatherName,string phone,string address,string description)
        {
            this.id = id;
            Surname = surname;
            Name = name;
            FatherName = fatherName;
            phoneNumber = phone;
            this.address = address;
            this.description = description;
        }
    }
}
