﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUP_BMI_Calculator
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            return Path.Combine(FileSystem.AppDataDirectory, filename);
        }
    }
}
