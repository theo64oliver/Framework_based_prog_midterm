﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUP_BMI_Calculator.Model
{
    [Table("BMIResult")]
    public class BMIResult
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }

        [Unique]
        public double Height { get; set; }

        [Unique]
        public double Weight { get; set; }

        [Unique]
        public double BMIScore { get; set; }

        [MaxLength(250), Unique]
        public string Result { get; set; }
    }
}
