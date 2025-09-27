namespace CSharpFlappyBird.Objects
{
    partial class Pipes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pctTopPipe = new PictureBox();
            pctBottomPipe = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctTopPipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBottomPipe).BeginInit();
            SuspendLayout();
            // 
            // pctTopPipe
            // 
            pctTopPipe.BackgroundImage = Properties.Resources.pipe_green;
            pctTopPipe.Location = new Point(0, -140);
            pctTopPipe.Name = "pctTopPipe";
            pctTopPipe.Size = new Size(52, 320);
            pctTopPipe.TabIndex = 0;
            pctTopPipe.TabStop = false;
            // 
            // pctBottomPipe
            // 
            pctBottomPipe.BackColor = Color.Transparent;
            pctBottomPipe.BackgroundImage = Properties.Resources.pipe_green;
            pctBottomPipe.Location = new Point(0, 262);
            pctBottomPipe.Name = "pctBottomPipe";
            pctBottomPipe.Size = new Size(52, 320);
            pctBottomPipe.TabIndex = 1;
            pctBottomPipe.TabStop = false;
            // 
            // Pipes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pctBottomPipe);
            Controls.Add(pctTopPipe);
            Name = "Pipes";
            Size = new Size(52, 442);
            Load += Pipes_Load;
            ((System.ComponentModel.ISupportInitialize)pctTopPipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBottomPipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox pctTopPipe;
        public PictureBox pctBottomPipe;
    }
}
