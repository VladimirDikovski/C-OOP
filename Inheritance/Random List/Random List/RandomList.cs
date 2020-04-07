namespace CustomRandomList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class RandomList:List<string>
    {
        public string RandomString()
        {
            var random = new Random();
            int index = random.Next(0, this.Count);
            this.RemoveAt(index);
            return this[index];

        }
    }
}
