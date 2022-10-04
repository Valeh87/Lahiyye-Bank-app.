using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiyye_bank_app_.DataBase
{
    public class Bank_G<T>
    {
        public List<T> Datas = new List<T>();
        public Bank_G()
        {
            Datas = new List<T>();
        }
    }
}
