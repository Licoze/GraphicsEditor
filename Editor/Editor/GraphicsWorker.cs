using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Editor.Figures;
namespace Editor
{
    enum Modes {Pencil,Line,Square,Circle}
    class GraphicsWorker
    {
        private static readonly GraphicsWorker _instance = new GraphicsWorker();
        private readonly Dictionary<Modes, IShape> _modules = new Dictionary<Modes, IShape>();
        private Modes _mode;
        private Graphics _gi;
        private GraphicsWorker()
        {
            
        }
        public Modes Mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode=value;
            }
        }
        public static GraphicsWorker Instance
        {
            get
            {
                return _instance;
            }
        }
       
        
       public void ClearGraphics()
        {
            _gi.Clear(Color.White);
        }
       public void InitializeGraphics(Graphics gi, Color line,Color fill)
        {
            _gi = gi;
            _modules.Add(Modes.Pencil, new FreeFormLine(ref gi,line));
            _modules.Add(Modes.Line, new Line(ref gi,line));
            _modules.Add(Modes.Circle, new Circle(ref gi,line,fill));
            _modules.Add(Modes.Square, new Rectangle(ref gi, line, fill));
        }
        public void MouseMove(object sender, MouseEventArgs e)
        {
            _modules[_mode].MouseMove(sender,e);
        }
        public void MouseDown(object sender, MouseEventArgs e)
        {
            _modules[_mode].MouseDown(sender, e);
        }
        public void MouseUp(object sender, MouseEventArgs e)
        {
            _modules[_mode].MouseUp(sender, e);
        }

    }
}
