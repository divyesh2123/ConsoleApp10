using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class IRB: IRBBase
    {
        public void Display()
        {
            DID = 1;
            Console.WriteLine(CreatedBy);
            Console.WriteLine(DID);
        }
    }
}
