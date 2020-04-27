using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(string name, string favoritFood) : base(name, favoritFood)
        {

        }

        public override string ExplainSelf()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"I am {this.Name} and my fovourite food is {this.FavouriteFood}");
            st.AppendLine("DJAAF");
            return st.ToString();
        }
    }
}
