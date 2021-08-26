﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Utilities
{
    public class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading data!");
        }

        public void SaveData(string name)
        {
            Console.WriteLine($"saving {name}");
        }
    }
}
