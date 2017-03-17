using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Editor.Figures
{
    class Circle : IClosed
    {
        Graphics _gi;
        private Color _line;
        private Color _fill;
        public Color LineColor
        {
            get
            {
                return _line;
            }

        }
        public Color FillColor
        {
            get
            {
                return _fill;
            }

        }
        public Circle(ref Graphics gi, Color line, Color fill)
        {
            _fill = fill;
            _line = line;
            _gi = gi;
        }
        public void MouseMove(object sender, MouseEventArgs e)
        {

        }
        public void MouseDown(object sender, MouseEventArgs e)
        {

        }
        public void MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
