﻿using Lahiyye_bank_app_.DataBase;
using Lahiyye_bank_app_.Models;
using Lahiyye_bank_app_.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lahiyye_bank_app_.Implementation
{
    public class BranchService : IBankService<Branch>, IBranchService
    {
        public Bank_G<Branch> _Bank;

        public BranchService()
        {
            _Bank = new Bank_G<Branch>();
        }
        //We create List Employee
        public void Create(Branch entity)
        {
            Branch branch = new Branch();
            _Bank.Datas.Add(branch);
            try
            {
                Console.WriteLine("--- Create Branch ---");
                Console.Write("Please enter the Name: ");
                string name = Console.ReadLine();
                Console.Write("Please enter the Budget: ");
                decimal budger = decimal.Parse(Console.ReadLine());
                Console.Write("Please enter the Address: ");
                string address = Console.ReadLine();
                branch.Name = name;
                branch.Budget = budger;
                branch.Address = address;
            }
            catch (Exception)
            {
                Console.WriteLine("You are not creating a worker correctly");
            }


        }
        public void Delete(Branch branch1)
        {
            Branch branch = _Bank.Datas.Find(d => d.Name.ToLower().Trim() == branch1.Name.ToLower().Trim());
            branch.SoftDelete = false;
        }

        public void Get()
        {
            try
            {
                Console.Write("Name: ");
                string entity = Console.ReadLine();
                Branch branch = _Bank.Datas.Find(g => g.Name.Contains(entity.Trim())
                || g.Budget.ToString().Contains(entity.Trim()) || g.Address.Contains(entity.Trim()));
            }
            catch (FormatException)
            {

                Console.WriteLine("Branch not found");
            }
        }

        public void GetAll()
        {
            foreach (Branch branch in _Bank.Datas.Where(d => d.SoftDelete == false))
            {
                Console.WriteLine(branch.Name);
            }
        }


        public void GetProfit(Branch branch)
        {
            Console.Write("Calculate profit and loss:\n");
            Console.Write("Input Cost Price: ");
            Console.Write("Input Selling Price: ");
            decimal sellprice = 0;
            branch.Employees.ForEach(c => sellprice += c.Salary);
            decimal getprofil = branch.Budget - sellprice;
            Console.WriteLine($"Profit of the {branch.Name}  branch in {getprofil}");

        }
        public void HireEmployee(Branch branch)
        {
            Employee employee = new Employee();
            if (branch.Budget > employee.Salary)
            {
                branch.Employees.Add(employee);
                branch.Budget -= employee.Salary;
                Console.WriteLine($"Employee {employee.Name} surname {employee.Surname} was successfully hired. ");
            }
        }
        //we are transferring employees to branches here
        public void TransferEmployee(Branch branch)
        {
            Employee employee = new Employee();
            if (branch.Budget > employee.Salary)
            {
                branch.Employees.Remove(employee);
                branch.Employees.Add(employee);
                branch.Budget -= employee.Salary;
                Console.WriteLine($"Employee {employee.Name} {employee.Surname} successfully transtfer from {branch.Address}");
            }
        }
        //we are transferring money to the employee
        public void TransferMoney()
        {
            Console.WriteLine("---Trasfer Money---");
            Console.Write("Please enter your Name: ");
            string yourname = Console.ReadLine();
            Console.Write("Please enter the Name of the person you would like to tranfer funds to: ");
            string name = Console.ReadLine();
            Console.Write("Enter the amount of funds you would like to transfer: ");
            string amount = Console.ReadLine();
            Branch branch = new Branch();
            foreach (Branch Transfer in _Bank.Datas)
            {
                if (Transfer.Name == name)
                {
                    Transfer.Budget -= branch.Budget;
                    break;
                }
            }
            foreach (Branch Transfer in _Bank.Datas)
            {
                if (Transfer.Name == name)
                {
                    branch.Budget += Transfer.Budget;
                    break;
                }
            }
        }





        //we are changing the current names, budget, address
        public void Update()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Branch branch = _Bank.Datas.Find(u => u.Name.ToLower().Trim() == name.Trim().ToLower());
            Console.Write("New budget: ");
            branch.Budget = decimal.Parse(Console.ReadLine());
            Console.Write("New Address: ");
            branch.Address = Console.ReadLine();
        }
    }
}