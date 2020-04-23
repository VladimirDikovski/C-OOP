using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrationss
{
    class Pet : IBrithDay
    {
        public Pet(string name ,string brithday)
        {
            this.Name = name;
            this.BrithDay = brithday;
        }
        public string Name { get; private set; }

        public string BrithDay { get; private set; }
    }
}
