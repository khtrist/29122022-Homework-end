﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _29122022_Homework
{
    internal class Sale
    {
        public string ProductName;
        public double Amount;
        public DateTime Date;

        public string GetInfo()
        {
            return $"Product: {ProductName} - Amount: {Amount} - Date: {Date.ToString("dd-MM-yyyy HH:mm")}";
        }
    }
}
