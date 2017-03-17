using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Editor.Figures
{
    class FreeFormLine : Shape
    {

        public FreeFormLine( Graphics gi, Color line):base(gi,line)
        {
            
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                _prev = _curr;
                _curr = e.Location;
                _gi.DrawLine(_line, _prev, _curr);
            }
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            _curr = e.Location;
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
        }

       
    }
}