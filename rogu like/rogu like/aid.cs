﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rogu_like
{
    internal class Aid
    {
        static Random rnd = new Random();
        public int hp = rnd.Next(0, 31);

    }
}