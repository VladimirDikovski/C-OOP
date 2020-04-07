namespace CustomStack
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class StackOfStrings :Stack<string>
    {
        public bool IsEmpty()
        {
            if (this.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddRange(Stack<string> values)
        {
            foreach (var item in values)
            {
                this.Push(item);
            }
        }

    }
}
