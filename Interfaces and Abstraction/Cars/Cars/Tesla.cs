using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model,string color,int battery)         
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }
        public int Battery { get; private set; }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries");
            st.AppendLine($"{this.Start()}");
            st.AppendLine($"{this.Stop()}");
            return st.ToString();
        }


    }
}
