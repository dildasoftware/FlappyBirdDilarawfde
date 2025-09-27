namespace CSharpFlappyBird.Objects
{
    partial class StartScreen
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
            pctStartScreen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctStartScreen).BeginInit();
            SuspendLayout();
            // 
            // pctStartScreen
            // 
            pctStartScreen.BackColor = Color.Transparent;
            pctStartScreen.BackgroundImage = Properties.Resources.message;
            pctStartScreen.Location = new Point(0, 0);
            pctStartScreen.Name = "pctStartScreen";
            pctStartScreen.Size = new Size(184, 267);
            pctStartScreen.TabIndex = 0;
            pctStartScreen.TabStop = false;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pctStartScreen);
            Name = "StartScreen";
            Size = new Size(184, 267);
            ((System.ComponentModel.ISupportInitialize)pctStartScreen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctStartScreen;
    }
}
