using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class mainForm : Form
    {
        private GraphicsWorker _gwi;
        public mainForm()
        {
           
            InitializeComponent();
            _gwi = GraphicsWorker.Instance;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _gwi.ClearGraphics();
        }

        private void cpnlLine_MouseClick(object sender, MouseEventArgs e)
        {
            if (lineColor.ShowDialog() == DialogResult.OK)
            {
                cpnlLine.BackColor = lineColor.Color;
                _gwi.LineColor= lineColor.Color;
            }
        }

        private void cpnlBG_MouseClick(object sender, MouseEventArgs e)
        {
            if (bgColor.ShowDialog() == DialogResult.OK)
            {
                cpnlBG.BackColor = bgColor.Color;
                _gwi.FillColor = bgColor.Color;
            }
        }

        private void rbtnPencil_CheckedChanged(object sender, EventArgs e)
        {
            _gwi.Mode = Modes.Pencil;
        }

        private void rbtnLine_CheckedChanged(object sender, EventArgs e)
        {
            _gwi.Mode = Modes.Line;
        }

        private void rbtnCirlcle_CheckedChanged(object sender, EventArgs e)
        {
            _gwi.Mode = Modes.Circle;
        }

        private void rbtnSquare_CheckedChanged(object sender, EventArgs e)
        {
            _gwi.Mode = Modes.Square;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
            drawPanel.Image = new Bitmap(drawPanel.Width, drawPanel.Height);
            _gwi.InitializeGraphics((drawPanel.Image as Bitmap), cpnlLine.BackColor, cpnlBG.BackColor);
            _gwi.ClearGraphics();
            drawPanel.MouseDown += _gwi.MouseDown;
            drawPanel.MouseMove += _gwi.MouseMove;
            drawPanel.MouseUp += _gwi.MouseUp;
            _gwi.progressChanged += ProgressChanged;
        }


        private void drawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            drawPanel.Refresh();
        }

        private void btnVert_Click(object sender, EventArgs e)
        {
            _gwi.VerticalFlip().Start(TaskScheduler.FromCurrentSynchronizationContext());
            
        }
        private void ProgressChanged(int x)
        {
            progress.Value = x;
        }
    }
}
