using Lahiyye_bank_app_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiyye_bank_app_.Service.Interface
{
    public interface IBranchService : IBankService<Branch>
    {
        void HireEmployee(Branch branch);
        void GetProfit();
        void TransferMoney();
        void TransferEmployee(Branch branch);
    }
}
