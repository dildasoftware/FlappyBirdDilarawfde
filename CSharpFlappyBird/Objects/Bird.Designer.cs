namespace CSharpFlappyBird.Objects
{
    partial class Bird
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
            pctBird = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctBird).BeginInit();
            SuspendLayout();
            // 
            // pctBird
            // 
            pctBird.BackColor = Color.Transparent;
            pctBird.BackgroundImage = Properties.Resources.yellowbird_midflap;
            pctBird.Location = new Point(0, 0);
            pctBird.Name = "pctBird";
            pctBird.Size = new Size(34, 24);
            pctBird.TabIndex = 0;
            pctBird.TabStop = false;
            // 
            // Bird
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pctBird);
            Name = "Bird";
            Size = new Size(34, 24);
            Load += Bird_Load;
            ((System.ComponentModel.ISupportInitialize)pctBird).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctBird;
    }
}
