using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Editor
{
   public interface IClosed:IShape
    {
        void FillColorChanged(Color color);

    }
}
