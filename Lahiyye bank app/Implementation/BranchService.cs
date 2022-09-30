﻿using Lahiyye_bank_app_.DataBase;
using Lahiyye_bank_app_.Models;
using Lahiyye_bank_app_.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiyye_bank_app_.Implementation
{
    public class BranchService:IBankService<Branch>,IBranchService
    {
        private Bank_G<Branch> _Bank;
        public BranchService()
        {
            _Bank = new Bank_G<Branch>();
        }
        public void Create(Branch branch)
        {
            _Bank.Datas.Add(branch);
        }
        public void Delete(string name)
        {
            Branch branch = _Bank.Datas.Find(d => d.Name.ToLower().Trim() == name.ToLower().Trim());
            branch.SoftDelete = false;
        }
        public void Get(string entity)
        {
            try
            {
                Branch branch = _Bank.Datas.Find(g => g.Name.Contains(entity.ToLower().Trim()) ||);
            }
            catch (FormatException)
            {
                Console.WriteLine("Branch Not found");
            }
        }
        public void GetAll()
        {
            foreach (Branch employee in _Bank.Datas.Where(d=> d.SoftDelete == false))
            {
                Console.WriteLine(employee.name);
            }
        }
        public void Getprofit(Branch entity)
        {

        }
        public void HireEmployee()
        {
            throw new NotImplementedException();
        }
        public void TransferMoney()
        {

        }
        public void Update(string name,decimal budget,string address)
        {
            Branch branch = _Bank.Datas.Find(u=>u.Name.ToLower().Trim() == name.Trim().ToLower());
            branch.Budget = budget;
            branch.Address = address;
        }
        
        


    }
}
