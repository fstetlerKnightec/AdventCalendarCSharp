﻿using AdventCalendarC_;
using AdventCalendarC_.dayone;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarCsharp {
    public class Primary {
        public static void Main(string[] args) {
            DayOne dayOne = new DayOne();
            dayOne.printSolutionOne();
            dayOne.printSolutionTwo();
        }
    }
}