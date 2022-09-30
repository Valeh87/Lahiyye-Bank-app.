using Lahiyye_bank_app_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiyye_bank_app_.Service.Interface
{
    public interface IBankService<T>where T:BaseEntity
    {
        void Creat(T entity);
        void Delete(string name);
        void Update(string text, decimal money, string info);
        void Get(string entity);
        void GetAll();
    }
}
