using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Models
{
    public class Expression:BaseEntity
    {
        public string Example { get; set; }
        public double Solution { get; set; }
    }
}
