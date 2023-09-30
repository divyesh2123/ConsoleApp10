using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Study : BaseEntity
    {
        public string Title { get; set; }   

        public string TypeOfStudy { get; set; }

        public string Desc { get; set; }    
    }
}
