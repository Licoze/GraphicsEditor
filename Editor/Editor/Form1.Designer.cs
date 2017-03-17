namespace Editor
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progress = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.ToolStripMenuItem();
            this.отразитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVert = new System.Windows.Forms.ToolStripMenuItem();
            this.поГоризонталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSquare = new System.Windows.Forms.RadioButton();
            this.rbtnCirlcle = new System.Windows.Forms.RadioButton();
            this.rbtnLine = new System.Windows.Forms.RadioButton();
            this.rbtnPencil = new System.Windows.Forms.RadioButton();
            this.cpnlLine = new System.Windows.Forms.Panel();
            this.cpnlBG = new System.Windows.Forms.Panel();
            this.lineColor = new System.Windows.Forms.ColorDialog();
            this.bgColor = new System.Windows.Forms.ColorDialog();
            this.drawPanel = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progress.Location = new System.Drawing.Point(-5, 450);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(692, 23);
            this.progress.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.действияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnOpen,
            this.toolStripMenuItem1,
            this.btnClose});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileMenuItem.Text = "Файл";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 22);
            this.btnSave.Text = "Сохранить";
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(129, 22);
            this.btnOpen.Text = "Открыть";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 6);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 22);
            this.btnClose.Text = "Выход";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClear,
            this.отразитьToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // btnClear
            // 
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 22);
            this.btnClear.Text = "Очистить";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // отразитьToolStripMenuItem
            // 
            this.отразитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVert,
            this.поГоризонталиToolStripMenuItem});
            this.отразитьToolStripMenuItem.Name = "отразитьToolStripMenuItem";
            this.отразитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.отразитьToolStripMenuItem.Text = "Отразить";
            // 
            // btnVert
            // 
            this.btnVert.Name = "btnVert";
            this.btnVert.Size = new System.Drawing.Size(154, 22);
            this.btnVert.Text = "По вертикали";
            this.btnVert.Click += new System.EventHandler(this.btnVert_Click);
            // 
            // поГоризонталиToolStripMenuItem
            // 
            this.поГоризонталиToolStripMenuItem.Name = "поГоризонталиToolStripMenuItem";
            this.поГоризонталиToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.поГоризонталиToolStripMenuItem.Text = "По горизонтали";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSquare);
            this.groupBox1.Controls.Add(this.rbtnCirlcle);
            this.groupBox1.Controls.Add(this.rbtnLine);
            this.groupBox1.Controls.Add(this.rbtnPencil);
            this.groupBox1.Location = new System.Drawing.Point(518, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фигура";
            // 
            // rbtnSquare
            // 
            this.rbtnSquare.AutoSize = true;
            this.rbtnSquare.Location = new System.Drawing.Point(6, 91);
            this.rbtnSquare.Name = "rbtnSquare";
            this.rbtnSquare.Size = new System.Drawing.Size(105, 17);
            this.rbtnSquare.TabIndex = 3;
            this.rbtnSquare.TabStop = true;
            this.rbtnSquare.Text = "Прямоугольник";
            this.rbtnSquare.UseVisualStyleBackColor = true;
            this.rbtnSquare.CheckedChanged += new System.EventHandler(this.rbtnSquare_CheckedChanged);
            // 
            // rbtnCirlcle
            // 
            this.rbtnCirlcle.AutoSize = true;
            this.rbtnCirlcle.Location = new System.Drawing.Point(7, 67);
            this.rbtnCirlcle.Name = "rbtnCirlcle";
            this.rbtnCirlcle.Size = new System.Drawing.Size(48, 17);
            this.rbtnCirlcle.TabIndex = 2;
            this.rbtnCirlcle.TabStop = true;
            this.rbtnCirlcle.Text = "Круг";
            this.rbtnCirlcle.UseVisualStyleBackColor = true;
            this.rbtnCirlcle.CheckedChanged += new System.EventHandler(this.rbtnCirlcle_CheckedChanged);
            // 
            // rbtnLine
            // 
            this.rbtnLine.AutoSize = true;
            this.rbtnLine.Location = new System.Drawing.Point(7, 43);
            this.rbtnLine.Name = "rbtnLine";
            this.rbtnLine.Size = new System.Drawing.Size(65, 17);
            this.rbtnLine.TabIndex = 1;
            this.rbtnLine.TabStop = true;
            this.rbtnLine.Text = "Прямая";
            this.rbtnLine.UseVisualStyleBackColor = true;
            this.rbtnLine.CheckedChanged += new System.EventHandler(this.rbtnLine_CheckedChanged);
            // 
            // rbtnPencil
            // 
            this.rbtnPencil.AutoSize = true;
            this.rbtnPencil.Location = new System.Drawing.Point(6, 19);
            this.rbtnPencil.Name = "rbtnPencil";
            this.rbtnPencil.Size = new System.Drawing.Size(76, 17);
            this.rbtnPencil.TabIndex = 0;
            this.rbtnPencil.TabStop = true;
            this.rbtnPencil.Text = "Карандаш";
            this.rbtnPencil.UseVisualStyleBackColor = true;
            this.rbtnPencil.CheckedChanged += new System.EventHandler(this.rbtnPencil_CheckedChanged);
            // 
            // cpnlLine
            // 
            this.cpnlLine.BackColor = System.Drawing.Color.Black;
            this.cpnlLine.Location = new System.Drawing.Point(540, 160);
            this.cpnlLine.Name = "cpnlLine";
            this.cpnlLine.Size = new System.Drawing.Size(50, 50);
            this.cpnlLine.TabIndex = 4;
            this.cpnlLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cpnlLine_MouseClick);
            // 
            // cpnlBG
            // 
            this.cpnlBG.BackColor = System.Drawing.Color.White;
            this.cpnlBG.Location = new System.Drawing.Point(620, 160);
            this.cpnlBG.Name = "cpnlBG";
            this.cpnlBG.Size = new System.Drawing.Size(50, 50);
            this.cpnlBG.TabIndex = 5;
            this.cpnlBG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cpnlBG_MouseClick);
            // 
            // bgColor
            // 
            this.bgColor.Color = System.Drawing.Color.White;
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.Color.White;
            this.drawPanel.Location = new System.Drawing.Point(0, 27);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(512, 417);
            this.drawPanel.TabIndex = 6;
            this.drawPanel.TabStop = false;
            this.drawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawPanel_MouseMove);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 470);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.cpnlBG);
            this.Controls.Add(this.cpnlLine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSquare;
        private System.Windows.Forms.RadioButton rbtnCirlcle;
        private System.Windows.Forms.RadioButton rbtnLine;
        private System.Windows.Forms.RadioButton rbtnPencil;
        private System.Windows.Forms.Panel cpnlLine;
        private System.Windows.Forms.Panel cpnlBG;
        private System.Windows.Forms.ColorDialog lineColor;
        private System.Windows.Forms.ColorDialog bgColor;
        private System.Windows.Forms.PictureBox drawPanel;
        private System.Windows.Forms.ToolStripMenuItem отразитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVert;
        private System.Windows.Forms.ToolStripMenuItem поГоризонталиToolStripMenuItem;
    }
}

