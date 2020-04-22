using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace BorderControl
{
    public class Citizen :IIdentifiable
    {
        public Citizen(string name ,int age ,string id)          
        {
            this.Name = name;
            this.Age = age;
            this.id = id;
        }
 
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string id { get; private set; }
    }
}
