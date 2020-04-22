using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot :IIdentifiable
    {
        public Robot(string model ,string id)          
        {
            this.Model = model;
            this.id = id;
        }

        public string Model { get; private set; }

        public string id { get; private set; }
    }
}
