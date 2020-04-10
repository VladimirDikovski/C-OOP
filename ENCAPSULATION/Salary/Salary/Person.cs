namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public Person(string fname,string lname,int age)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
        }
        public Person(string fname,string lname,int age,decimal salary)
            :this(fname,lname,age)
        {
            this.Salary = salary;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            int devider = 100;
            if (this.Age < 30)
            {
                devider = 200;
            }
            this.Salary += this.Salary * percentage / devider;

        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}
