using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Editor
{
    public abstract class Closed: Shape,IClosed
    {
        protected Brush _fill;
        public Closed(Graphics gi, Color lcolor, Color fcolor):base(gi, lcolor)
        {
            _fill = new SolidBrush(fcolor);
        }

        public void FillColorChanged(Color color)
        {
            _fill = new SolidBrush(color);
        }
   

    }
}
