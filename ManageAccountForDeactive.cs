using ConsoleApp10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class ManageAccountForDeactive: BaseAccount
    {

        public override List<string> UpdateParameters()
        {
            var d = new List<string>();
            d.Add("status");


            return d;

        }

        public override void DisplayAccount()
        {
            using ErpContext erpContext = new ErpContext();
           var d = erpContext.Accounts.Where(y => y.IsActive == false).ToList();

            foreach(var  p in d)
            {
                Console.WriteLine(p.AccountName);
            }
        }
    }
}
