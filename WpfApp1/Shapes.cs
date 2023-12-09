using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public abstract class Shapes
    {
        public abstract string Name { get; set; }
        public abstract float Length { get; set; }
        public abstract float Width { get; set; }
        public abstract float Height { get; set; }

        public override string ToString()
        {
            string output = $"You select {Name} widht dimensions of {Length}, {Width}, {Height}";
            return output;
        }

    }
}
