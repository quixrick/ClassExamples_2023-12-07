using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Pyramid: Shapes
    {
        public override string Name { get; set; }
        public override float Length { get; set; }
        public override float Width { get; set; }
        public override float Height { get; set; }

        public Pyramid(string name, float length, float width, float height)
        {
            Name = Name;
            Length = length;
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            string output = "You selected a pyramid." + base.ToString();
            return output;
        }
    }
}
