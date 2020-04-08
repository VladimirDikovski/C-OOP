namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Kitten : Cat
    {
        private const string kittisGender = "Female";
        public Kitten(string name, int age)
            : base(name, age, kittisGender)
        {

        }
        public override string ProduceSound()
        {
            return "Meow";
        }

    }
}
