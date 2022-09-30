using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiyye_bank_app_.Models
{
    public class Employee:BaseEntity
    {
        internal decimal budget;
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public string Profession { get; set; }
        public Branch Branch { get; set; }
        public Employee(string name, string surname,decimal salary, string professin)
        {
            this.Name = name;
            this.Surname = surname;
            this.Salary = salary;
            this.SoftDelete = false;
            this.Profession = professin;
            
            
        }
    }
}
