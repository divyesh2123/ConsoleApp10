﻿using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public interface INotification
    {
       public void display()
        {

        }


        void SendNotification();
    }
}
