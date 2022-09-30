using Lahiyye_bank_app_.DataBase;
using Lahiyye_bank_app_.Models;
using Lahiyye_bank_app_.Service.Interface;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace Lahiyye_bank_app_.Implementation
{
    public class EmployeeService:IBankService<Employee>,IEmployeeService
    {
        private Bank_G<Employee> _employees;
        public EmployeeService()
        {
            _employees = new Bank_G<Employee>();
        }
        public void Create(Employee entity)
        {
            _employees.Datas.Add(entity);
        }
        public void Delete(string name)
        {
            Employee employee = _employees.Datas.Find(x => x.Name.ToLower().Trim() name.ToLower().Trim());
            employee.SoftDelete = true;
            GetAll();
        }
        public void Get(string entity)
        {
            Employee employee = _employees.Datas.Find(x => x.Name.Contains(entity.ToLower().Trim()) || x.Surname.Contains(entity.ToLower().Trim()) || x.Professin.Contains(entity.ToLower().Trim()));
            Console.WriteLine(employee.Name + " " + employee.Surname + " " + employee.Profession);
        }
        public void GetAll()
        {
            foreach (Employee employee in _employees.Datas.Where(d => d.SoftDelete == false))
            {
                Console.WriteLine(employee.Name+ " " + employee.Surname);
            }
        }
        public void Update(string name, decimal salary, string profession)
        {
            Employee employee=_employees.Datas.Find(u => u.Name.ToLower().Trim()==name.ToLower().Trim());
            employee.Salary = salary;
            employee.Profession = profession;
        }

    }
}
