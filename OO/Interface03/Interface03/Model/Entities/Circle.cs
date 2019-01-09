﻿using Enums;
using Interface03.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return "Circle color = " + Color + ", radius = ";
        }
    }
}
