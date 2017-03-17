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
        delegate void ColorChanged(Color color);
        private event ColorChanged lineChanged;
        private event ColorChanged fillChanged;
        private static readonly GraphicsWorker _instance = new GraphicsWorker();
        private readonly Dictionary<Modes, IShape> _modules = new Dictionary<Modes, IShape>();
        private Modes _mode;
        private Graphics _gi;
        private Color _line;
        private Color _fill;
       
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

        public Color LineColor
        {

            set
            {
                _line = value;
                OnLineChanged(_line);
            }

        }
        public Color FillColor
        {
            set
            {
                _fill = value;
                OnFillChanged(_fill);
            }

        }
        public void ClearGraphics()
        {
            _gi.Clear(Color.White);
        }
        private void OnFillChanged(Color color)
        {
            fillChanged?.Invoke(color);
        }
        private void OnLineChanged(Color color)
        {
            lineChanged?.Invoke(color);
        }

        public void InitializeGraphics(Graphics gi, Color line,Color fill)
        {
            _gi = gi;
            _modules.Add(Modes.Pencil, new FreeFormLine(gi,line));
            _modules.Add(Modes.Line, new Line(gi,line));
            _modules.Add(Modes.Circle, new Circle( gi,line,fill));
            _modules.Add(Modes.Square, new Rectangle( gi, line, fill));
            lineChanged += _modules[Modes.Pencil].LineColorChanged;
            lineChanged += _modules[Modes.Line].LineColorChanged;
            lineChanged += _modules[Modes.Circle].LineColorChanged;
            lineChanged += _modules[Modes.Square].LineColorChanged;
            fillChanged += (_modules[Modes.Circle] as IClosed).FillColorChanged;
            fillChanged += (_modules[Modes.Square] as IClosed).FillColorChanged;
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
