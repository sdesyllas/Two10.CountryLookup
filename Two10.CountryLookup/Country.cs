﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two10.CountryLookup
{

    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public float[][] Polygon { get; set; }
    }
}