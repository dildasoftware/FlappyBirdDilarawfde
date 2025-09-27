namespace CSharpFlappyBird.Objects
{
    partial class ScoreBoard
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
            pctLeftNumber = new PictureBox();
            pctRightNumber = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctLeftNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctRightNumber).BeginInit();
            SuspendLayout();
            // 
            // pctLeftNumber
            // 
            pctLeftNumber.BackColor = Color.Transparent;
            pctLeftNumber.BackgroundImage = Properties.Resources._0;
            pctLeftNumber.BackgroundImageLayout = ImageLayout.None;
            pctLeftNumber.Location = new Point(0, 0);
            pctLeftNumber.Name = "pctLeftNumber";
            pctLeftNumber.Size = new Size(24, 36);
            pctLeftNumber.TabIndex = 0;
            pctLeftNumber.TabStop = false;
            // 
            // pctRightNumber
            // 
            pctRightNumber.BackColor = Color.Transparent;
            pctRightNumber.BackgroundImage = Properties.Resources._0;
            pctRightNumber.BackgroundImageLayout = ImageLayout.None;
            pctRightNumber.Location = new Point(24, 0);
            pctRightNumber.Name = "pctRightNumber";
            pctRightNumber.Size = new Size(24, 36);
            pctRightNumber.TabIndex = 1;
            pctRightNumber.TabStop = false;
            // 
            // ScoreBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pctRightNumber);
            Controls.Add(pctLeftNumber);
            Name = "ScoreBoard";
            Size = new Size(48, 36);
            ((System.ComponentModel.ISupportInitialize)pctLeftNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctRightNumber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctLeftNumber;
        private PictureBox pctRightNumber;
    }
}
