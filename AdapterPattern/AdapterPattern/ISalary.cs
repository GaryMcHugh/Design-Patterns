﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface ISalary
    { 
        void ProcessCompanySalary(string[,] employeesArray);
    }
}
