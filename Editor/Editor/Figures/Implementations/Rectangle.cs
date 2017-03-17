using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Editor
{
    public class Rectangle:Closed
    {

        public Rectangle(Graphics gi, Color line, Color fill):base(gi,line,fill)
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
                var rect = new System.Drawing.Rectangle(
                             Math.Min(_prev.X, _curr.X),
                             Math.Min(_prev.Y, _curr.Y),
                             Math.Abs(_curr.X - _prev.X),
                             Math.Abs(_curr.Y - _prev.Y));
                _gi.DrawRectangle(_line, rect);
                _gi.FillRectangle(_fill, rect);


            }

            isPressed = false;
        }
    }
}
