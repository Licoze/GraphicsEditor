using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Editor.Figures;
namespace Editor
{
    enum Modes {Pencil,Line,Square,Circle}
    class GraphicsWorker
    {
        private delegate void ColorChanged(Color color);
        public delegate void ProgressChanged(int currProgress);
        private event ColorChanged lineChanged;
        private event ColorChanged fillChanged;
        public event ProgressChanged progressChanged;
        private static readonly GraphicsWorker _instance = new GraphicsWorker();
        private readonly Dictionary<Modes, IShape> _modules = new Dictionary<Modes, IShape>();
        private Modes _mode;
        private Graphics _gi;
        private Color _line;
        private Color _fill;
        private Bitmap _image;
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
                _mode = value;
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
        private void OnProgressChanged(int currProgress)
        {
            progressChanged?.Invoke(currProgress);
        }
        public void InitializeGraphics(Bitmap img, Color line, Color fill)
        {
            _gi = Graphics.FromImage(img);
            _image = img;
            _modules.Add(Modes.Pencil, new FreeFormLine(_gi, line));
            _modules.Add(Modes.Line, new Line(_gi, line));
            _modules.Add(Modes.Circle, new Circle(_gi, line, fill));
            _modules.Add(Modes.Square, new Rectangle(_gi, line, fill));
            lineChanged += _modules[Modes.Pencil].LineColorChanged;
            lineChanged += _modules[Modes.Line].LineColorChanged;
            lineChanged += _modules[Modes.Circle].LineColorChanged;
            lineChanged += _modules[Modes.Square].LineColorChanged;
            fillChanged += (_modules[Modes.Circle] as IClosed).FillColorChanged;
            fillChanged += (_modules[Modes.Square] as IClosed).FillColorChanged;
        }
        public void MouseMove(object sender, MouseEventArgs e)
        {
            _modules[_mode].MouseMove(sender, e);
        }
        public void MouseDown(object sender, MouseEventArgs e)
        {
            _modules[_mode].MouseDown(sender, e);
        }
        public void MouseUp(object sender, MouseEventArgs e)
        {
            _modules[_mode].MouseUp(sender, e);
        }
        public Task VerticalFlip()
        {

            
            return new Task(() =>
            {
                for (int x = 0; x <= _image.Width - 1; x++)
                {
                    Thread.Sleep(3);
                    double prog = 100 * x / _image.Width;
                    OnProgressChanged((int)Math.Truncate(prog));
                    for (int y = 0; y <= _image.Height / 2; y++)
                    {
                        
                        Color p1 = _image.GetPixel(x, y);
                        Color p2 = _image.GetPixel(x, _image.Height - y - 1);
                        
                        _image.SetPixel(x, y, p2);
                        _image.SetPixel(x, _image.Height - y - 1, p1);

                    }
                }
                OnProgressChanged(0);
               
            });
        }
    }
}
