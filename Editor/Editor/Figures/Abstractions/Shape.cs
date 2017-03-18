using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Editor
{
   public abstract class Shape:IShape
    {
        protected Graphics _gi;
        protected bool isPressed = false;
        protected Point _prev;
        protected Point _curr;
        protected Pen _line;
        public Shape(Graphics gi, Color lcolor)
        {
            _line = new Pen(lcolor, 2);
            _gi = gi;
        }
        public abstract void MouseMove(object sender, MouseEventArgs e);
        public abstract void MouseDown(object sender, MouseEventArgs e);
        public abstract void MouseUp(object sender, MouseEventArgs e);

        public void LineColorChanged(Color color)
        {
            
            _line = new Pen(color, 2);
        }
     
    }
}
