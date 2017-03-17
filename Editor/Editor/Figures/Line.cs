using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Editor.Figures
{
    class Line:IShape
    {
        Graphics _gi;
        private Color _line;
        public Color LineColor
        {
            get
            {
                return _line;
            }

        }
   
        public Line(ref Graphics gi, Color line)
        {
          
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
