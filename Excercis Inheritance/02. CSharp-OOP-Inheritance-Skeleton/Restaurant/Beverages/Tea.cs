﻿namespace Restaurant.Beverages
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Tea:HotBeverage
    {
        public Tea(string name,decimal price ,double militurs)
            :base(name,price,militurs)
        {

        }
    }
}
