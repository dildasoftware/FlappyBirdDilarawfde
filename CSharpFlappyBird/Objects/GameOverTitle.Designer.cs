namespace CSharpFlappyBird.Objects
{
    partial class GameOverTitle
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
            pctGameOver = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctGameOver).BeginInit();
            SuspendLayout();
            // 
            // pctGameOver
            // 
            pctGameOver.BackColor = Color.Transparent;
            pctGameOver.BackgroundImage = Properties.Resources.gameover;
            pctGameOver.Location = new Point(0, 0);
            pctGameOver.Name = "pctGameOver";
            pctGameOver.Size = new Size(192, 42);
            pctGameOver.TabIndex = 0;
            pctGameOver.TabStop = false;
            // 
            // GameOver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pctGameOver);
            Name = "GameOver";
            Size = new Size(192, 42);
            ((System.ComponentModel.ISupportInitialize)pctGameOver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctGameOver;
    }
}
