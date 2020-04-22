namespace PersonInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;

    public class Citizen : IPerson
    {
        public Citizen(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; private set; }

        public int Age { get; private set; }
    }
}
