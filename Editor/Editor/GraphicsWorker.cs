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
        #region Fields
        private delegate void ColorChanged(Color color);
        public delegate void ProgressChanged(int currProgress);
        private event ColorChanged lineChanged;
        private event ColorChanged fillChanged;
        public event ProgressChanged progressChanged;
        private static readonly GraphicsWorker _instance = new GraphicsWorker();
        private Dictionary<Modes, IShape> _modules;
        private Modes _mode;
        private Graphics _gi;
        private Color _line;
        private Color _fill;
        private Bitmap _image;
        #endregion
        private GraphicsWorker()
        {

        }
        #region Properties
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
        #endregion
        public void ClearGraphics()
        {
            _gi.Clear(Color.White);
        }
        #region Event methods
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
        #endregion
        public void InitializeGraphics(Bitmap img, Color line, Color fill)
        {
            _modules = new Dictionary<Modes, IShape>();
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
       
        #region Mouse events
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
        #endregion
        #region Transforms
        public async Task<Bitmap> VerticalFlipAsync()
        {
        
            IProgress< int> progress = new Progress<int>((i) =>{ OnProgressChanged(i); });
            Bitmap changed = new Bitmap(_image);
            return await Task.Run(() =>
              {
                  for (int x = 0; x <= changed.Width - 1; x++)
                  {                    
                      double prog = 100 * x / changed.Width;
                      progress.Report((int)Math.Truncate(prog));
                      for (int y = 0; y <= changed.Height / 2; y++)
                      {
                          Color p1 = changed.GetPixel(x, y);
                          Color p2 = changed.GetPixel(x, changed.Height - y - 1);
                          changed.SetPixel(x, y, p2);
                          changed.SetPixel(x, changed.Height - y - 1, p1);
                      }
                  }
                  progress.Report(0);
                  _image = changed;                 
                  return _image;
              });
            
        }
        
        public async Task<Bitmap> HorizontalFlipAsync()
        {

            IProgress<int> progress = new Progress<int>((i) => { OnProgressChanged(i); });
            Bitmap changed = new Bitmap(_image);
            return await Task.Run(() =>
            {
                for (int y= 0; y <= changed.Height - 1; y++)
                {
                    double prog = 100 * y / changed.Width;
                    progress.Report((int)Math.Truncate(prog));
                    for (int x = 0; x<= changed.Width / 2; x++)
                    {
                        Color p1 = changed.GetPixel(x, y);
                        Color p2 = changed.GetPixel(changed.Width-x-1, y);
                        changed.SetPixel(x, y, p2);
                        changed.SetPixel(changed.Width - x - 1, y, p1);
                    }
                }
                progress.Report(0);
                _image = changed;
                return _image;
            });

        }
        #endregion
    }
}
