﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat :ICar
    {
        public Seat(string model,string color)           
        {
            this.Model = model;
            this.Color = color;
        }

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
            st.AppendLine($"{this.Color} Seat {this.Model}");
            st.AppendLine($"{this.Start()}");
            st.AppendLine($"{this.Stop()}");
            return st.ToString();
        }
    }
}
