﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShop.HR
{
    internal class StoreManager: Employee
    {
       public StoreManager(string firstName, string lastNmae, string email, DateTime birthDay, double? hourlyRate) : base(
           firstName, lastNmae, email, birthDay, hourlyRate)
        {
        }
  
    }
}
