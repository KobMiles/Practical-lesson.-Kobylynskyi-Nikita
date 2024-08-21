using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _2024_PracLesson
{
    public class Citrus : Fruit
    {
        private double _vitaminC;
        public double VitaminC
        {
            get { return _vitaminC; }
            set { _vitaminC = value; }
        }
        public Citrus(string name, string color, double vitaminC) : base(name, color)
        {
            _vitaminC = vitaminC;
        }
        
        override public string Input()
        {
            return Console.ReadLine();
        }
        override public void Print(string data)
        {
            Console.WriteLine(data);
        }
        override public string ToString()
        {
            return $"Name: {_name}, Color: {_color}, VitaminC: {_vitaminC}";
        }
    }
}
