﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Model
{
   public class Results
    {
        public int TestId { get; set; }
        public string NameTestDone { get; set; }
        public string User_login { get; set; }
        public int CathegoryId { get; set; }
        public string LearningUrlTestDone { get; set; }
        public string MedalImage { get; set; }
        public double Scoreprecennt { get; set; }
    }
}
