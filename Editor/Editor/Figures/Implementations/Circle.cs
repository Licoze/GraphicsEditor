using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Editor.Figures
{
    class Circle : Closed
    {

        public Circle( Graphics gi, Color line, Color fill):base(gi,line,fill)
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
                var side = Math.Min(_curr.X - _prev.X, _curr.X - _prev.X);
                var rect = new System.Drawing.Rectangle(_prev, new Size(side, side));
                _gi.DrawEllipse(_line, rect);
                _gi.FillEllipse(_fill, rect);


            }

            isPressed = false;
        }
      
    }
}
