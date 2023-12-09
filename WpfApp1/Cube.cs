using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Cube : Shapes
    {
        public override string Name { get; set; }
        public override float Length { get; set; }
        public override float Width { get; set; }
        public override float Height { get; set; }

        public Cube(string name, float length, float width, float height)
        {
            Name = Name;
            Length = length;
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            string output = "You selected a cube." + base.ToString();
            return output;
        }
    }
}
