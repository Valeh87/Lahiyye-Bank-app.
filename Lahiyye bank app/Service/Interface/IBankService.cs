using Lahiyye_bank_app_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiyye_bank_app_.Service.Interface
{
    public interface IBankService<T> where T : BaseEntity
    {
        void Create(T entity);
        void Delete(T branch);
        void Update();
        void Get();
        void GetAll();
    }
}
