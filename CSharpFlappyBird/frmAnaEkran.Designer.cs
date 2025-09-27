
namespace CSharpFlappyBird
{
    partial class frmAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaEkran));
            btnOyunaBasla = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            txtAd = new DevExpress.XtraEditors.TextEdit();
            txtAdLabel = new DevExpress.XtraEditors.LabelControl();
            txtSkorLabel = new DevExpress.XtraEditors.LabelControl();
            txtSkor = new DevExpress.XtraEditors.TextEdit();
            btnSkorKaydet = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSkor.Properties).BeginInit();
            SuspendLayout();
            // 
            // btnOyunaBasla
            // 
            btnOyunaBasla.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOyunaBasla.Appearance.Options.UseFont = true;
            btnOyunaBasla.ImageOptions.Image = (Image)resources.GetObject("btnOyunaBasla.ImageOptions.Image");
            btnOyunaBasla.Location = new Point(565, 12);
            btnOyunaBasla.Name = "btnOyunaBasla";
            btnOyunaBasla.Size = new Size(223, 56);
            btnOyunaBasla.TabIndex = 0;
            btnOyunaBasla.Text = "Oyuna Başla";
            btnOyunaBasla.Click += btnOyunaBasla_Click;
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(10, 12);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(547, 426);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2 });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Ad";
            gridColumn1.FieldName = "Ad";
            gridColumn1.MinWidth = 25;
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Skor";
            gridColumn2.FieldName = "Skor";
            gridColumn2.MinWidth = 25;
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 94;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(565, 96);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(223, 22);
            txtAd.TabIndex = 2;
            // 
            // txtAdLabel
            // 
            txtAdLabel.Appearance.Font = new Font("Tahoma", 8.8F);
            txtAdLabel.Appearance.Options.UseFont = true;
            txtAdLabel.Location = new Point(565, 72);
            txtAdLabel.Name = "txtAdLabel";
            txtAdLabel.Size = new Size(79, 18);
            txtAdLabel.TabIndex = 3;
            txtAdLabel.Text = "Oyuncu Adı:";
            txtAdLabel.Click += labelControl1_Click;
            // 
            // txtSkorLabel
            // 
            txtSkorLabel.Appearance.Font = new Font("Tahoma", 8.8F);
            txtSkorLabel.Appearance.Options.UseFont = true;
            txtSkorLabel.Location = new Point(565, 124);
            txtSkorLabel.Name = "txtSkorLabel";
            txtSkorLabel.Size = new Size(33, 18);
            txtSkorLabel.TabIndex = 6;
            txtSkorLabel.Text = "Skor:";
            txtSkorLabel.Click += labelControl2_Click;
            // 
            // txtSkor
            // 
            txtSkor.Location = new Point(565, 147);
            txtSkor.Name = "txtSkor";
            txtSkor.Size = new Size(223, 22);
            txtSkor.TabIndex = 5;
            // 
            // btnSkorKaydet
            // 
            btnSkorKaydet.Appearance.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSkorKaydet.Appearance.Options.UseFont = true;
            btnSkorKaydet.ImageOptions.Image = (Image)resources.GetObject("btnSkorKaydet.ImageOptions.Image");
            btnSkorKaydet.Location = new Point(563, 175);
            btnSkorKaydet.Name = "btnSkorKaydet";
            btnSkorKaydet.Size = new Size(223, 56);
            btnSkorKaydet.TabIndex = 4;
            btnSkorKaydet.Text = "Skoru Kaydet";
            btnSkorKaydet.Click += btnSkorKaydet_Click;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(609, 237);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(145, 28);
            labelControl1.TabIndex = 7;
            labelControl1.Text = "DİLARA BİLİŞİK";
            // 
            // frmAnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(labelControl1);
            Controls.Add(txtSkorLabel);
            Controls.Add(txtSkor);
            Controls.Add(btnSkorKaydet);
            Controls.Add(txtAdLabel);
            Controls.Add(txtAd);
            Controls.Add(gridControl1);
            Controls.Add(btnOyunaBasla);
            Name = "frmAnaEkran";
            Text = "AnaEkran";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSkor.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOyunaBasla;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl txtAdLabel;
        private DevExpress.XtraEditors.LabelControl txtSkorLabel;
        private DevExpress.XtraEditors.TextEdit txtSkor;
        private DevExpress.XtraEditors.SimpleButton btnSkorKaydet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}