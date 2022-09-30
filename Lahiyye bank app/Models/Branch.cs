using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiyye_bank_app_.Models
{
    public class Branch:BaseEntity
    {
        public decimal Budget { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; }
        public Branch(string name, decimal budget, string address)
        {
            this.Name = name;
            this.Budget = budget;
            this.Address = address;
            this.SoftDelet = false;
            this.Employees = new List<Employee>();
        }


    }
}
