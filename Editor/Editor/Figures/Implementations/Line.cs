using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Editor.Figures
{
    class Line:Shape
    {
 
        public Line(Graphics gi, Color line):base(gi,line)
        {
            
        }
        public override void MouseMove(object sender, MouseEventArgs e)
        {
           
        }
        public override void MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;
            _curr = e.Location;
            
        }
        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                _prev = _curr;
                _curr = e.Location;
                
                _gi.DrawLine(_line, _prev, _curr);

            }
            
            isPressed = false;
        }
       
    }
}
