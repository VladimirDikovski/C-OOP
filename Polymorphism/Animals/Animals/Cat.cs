using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name ,string favoriteFood)
            :base(name,favoriteFood)
        {

        }
        public override string ExplainSelf()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"I am {this.Name} and my fovourite food is {this.FavouriteFood}");
            st.AppendLine("MEEOW");
            return st.ToString();
        }
    }
}
