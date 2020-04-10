namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        private decimal salary;
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
        public string FirstName
        {
            get
            {
                return this.firstname;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                this.firstname = value;
            }
        }
        
        public string LastName
        {
            get
            {
                return this.lastname;
            }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                this.lastname = value;
            }
        }
        
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this.age = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            private set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                this.salary = value;
            }
        }

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
            return $"{this.FirstName} {this.LastName} gets {this.Salary:f2} leva.";
        }
    }
}
