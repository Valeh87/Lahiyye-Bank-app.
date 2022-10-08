using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiyye_bank_app_.Models
{
    public class Branch : BaseEntity
    {
        //Filial
        public decimal Budget { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; }

    }
}
