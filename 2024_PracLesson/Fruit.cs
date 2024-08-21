using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_PracLesson
{
    public class Fruit
    {
        public string _name;
        public string _color;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Fruit(string name, string color)
        {
            _name = name;
            _color = color;
        }

        public virtual string Input()
        {
            return Console.ReadLine();
        }
        
        public virtual void Print(string data)
        {
            Console.WriteLine(data);
        }

        public override string ToString()
        {
            return $"Name: {_name}, Color: {_color}";
        }
    }
}
