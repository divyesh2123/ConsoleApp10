using ConsoleApp10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class BaseAccount
    {
        public virtual List<string> UpdateParameters()
        {
            var d = new List<string>();
            d.Add("UpdatedData");


            return d;

        }

        public virtual void DisplayAccount()
        {
            using ErpContext erpContext = new ErpContext(); 

            var list = erpContext.Accounts.ToList();    


            foreach(var t in list)
            {

                Console.WriteLine(t.AccountName);
            }
        }
    }
}
