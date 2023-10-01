using DatabaseOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class IRBBase : Display
    {

        protected string CreatedBy { get; set; }    

        protected string UpdatedBy { get; set; }    

        protected DateTime CreatedDate { get; set; }    

        protected string UpdatedDate { get; set;}

        public void op()
        {
            Console.WriteLine(DID);
        }
    }
}
