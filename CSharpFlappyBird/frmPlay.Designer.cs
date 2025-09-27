namespace CSharpFlappyBird
{
    partial class frmPlay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTop = new Panel();
            lblTitle = new Label();
            btnExit = new Button();
            pnlCanvas = new Panel();
            pnlGround = new Panel();
            pnlTop.SuspendLayout();
            pnlCanvas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTop.BackColor = Color.Silver;
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(btnExit);
            pnlTop.Location = new Point(5, 5);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(5, 0, 0, 0);
            pnlTop.Size = new Size(991, 30);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(440, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(101, 19);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Dilara Bilişik";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.DarkSlateGray;
            btnExit.Location = new Point(961, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 0;
            btnExit.TabStop = false;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlCanvas
            // 
            pnlCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCanvas.BackgroundImage = Properties.Resources.background_day;
            pnlCanvas.Controls.Add(pnlGround);
            pnlCanvas.Location = new Point(5, 40);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(991, 512);
            pnlCanvas.TabIndex = 1;
            // 
            // pnlGround
            // 
            pnlGround.BackgroundImage = Properties.Resources._base;
            pnlGround.Location = new Point(0, 442);
            pnlGround.Name = "pnlGround";
            pnlGround.Size = new Size(993, 70);
            pnlGround.TabIndex = 0;
            // 
            // frmPlay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1001, 557);
            Controls.Add(pnlCanvas);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "frmPlay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dilara Bilişik";
            Load += frmMain_Load;
            KeyDown += frmMain_KeyDown;
            KeyUp += frmMain_KeyUp;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlCanvas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Panel pnlCanvas;
        private Button btnExit;
        private Panel pnlGround;
        private Label lblTitle;
    }
}
