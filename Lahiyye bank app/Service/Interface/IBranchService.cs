﻿using Lahiyye_bank_app_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiyye_bank_app_.Service.Interface
{
    public interface IBranchService:IBankService<Branch>
    {
        void HireEmployee();
        void GetProfit(Branch entity);
        void TransferMoney();
        void TransferEmployee();
    }
}
