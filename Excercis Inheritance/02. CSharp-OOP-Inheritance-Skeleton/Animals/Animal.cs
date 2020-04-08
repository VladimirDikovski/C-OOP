﻿namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name ,int age ,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }

                this.name = value;
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
                if (value < 1)
                {
                    throw new ArgumentException("Invalid input!");
                    
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            protected set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }            
                this.gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"{this.GetType().Name}");
            st.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            st.Append($"{this.ProduceSound()}");
            return st.ToString();
        }

    }
}
