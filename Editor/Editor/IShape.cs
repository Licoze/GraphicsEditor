using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Editor
{
   public interface IShape
    {
        Color LineColor { get; }
        void MouseMove(object sender, MouseEventArgs e);
        void MouseDown(object sender, MouseEventArgs e);
        void MouseUp(object sender, MouseEventArgs e);
    }
}
