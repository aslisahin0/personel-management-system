
namespace personelYonetimi
{
    partial class DeptIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeptSil = new System.Windows.Forms.Button();
            this.btnDeptGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridPersonel = new System.Windows.Forms.DataGridView();
            this.testdbDataSet1 = new personelYonetimi.testdbDataSet1();
            this.dEPARTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dEPARTMENTTableAdapter = new personelYonetimi.testdbDataSet1TableAdapters.DEPARTMENTTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDepİslemler = new System.Windows.Forms.Button();
            this.btnPrsnlIslemler = new System.Windows.Forms.Button();
            this.BtnTkmIslemleri = new System.Windows.Forms.Button();
            this.buttobtnMngrIslemleri = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.btnDeptSil);
            this.groupBox2.Controls.Add(this.btnDeptGuncelle);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.txtDeptName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(258, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 192);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // btnDeptSil
            // 
            this.btnDeptSil.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeptSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeptSil.ForeColor = System.Drawing.Color.White;
            this.btnDeptSil.Location = new System.Drawing.Point(153, 148);
            this.btnDeptSil.Name = "btnDeptSil";
            this.btnDeptSil.Size = new System.Drawing.Size(103, 29);
            this.btnDeptSil.TabIndex = 16;
            this.btnDeptSil.Text = "Sil";
            this.btnDeptSil.UseVisualStyleBackColor = false;
            this.btnDeptSil.Click += new System.EventHandler(this.btnDeptSil_Click);
            // 
            // btnDeptGuncelle
            // 
            this.btnDeptGuncelle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDeptGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeptGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnDeptGuncelle.Location = new System.Drawing.Point(28, 148);
            this.btnDeptGuncelle.Name = "btnDeptGuncelle";
            this.btnDeptGuncelle.Size = new System.Drawing.Size(119, 29);
            this.btnDeptGuncelle.TabIndex = 15;
            this.btnDeptGuncelle.Text = "Güncelle";
            this.btnDeptGuncelle.UseVisualStyleBackColor = false;
            this.btnDeptGuncelle.Click += new System.EventHandler(this.btnDeptGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.Location = new System.Drawing.Point(28, 103);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(228, 39);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtDeptName
            // 
            this.txtDeptName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDeptName.Location = new System.Drawing.Point(132, 49);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(143, 20);
            this.txtDeptName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(162, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Departman İşlemleri";
            // 
            // dataGridPersonel
            // 
            this.dataGridPersonel.AllowUserToOrderColumns = true;
            this.dataGridPersonel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonel.Location = new System.Drawing.Point(592, 168);
            this.dataGridPersonel.Name = "dataGridPersonel";
            this.dataGridPersonel.Size = new System.Drawing.Size(143, 192);
            this.dataGridPersonel.TabIndex = 0;
            this.dataGridPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPersonel_CellClick);
            // 
            // testdbDataSet1
            // 
            this.testdbDataSet1.DataSetName = "testdbDataSet1";
            this.testdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEPARTMENTBindingSource
            // 
            this.dEPARTMENTBindingSource.DataMember = "DEPARTMENT";
            this.dEPARTMENTBindingSource.DataSource = this.testdbDataSet1;
            // 
            // dEPARTMENTTableAdapter
            // 
            this.dEPARTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnDepİslemler);
            this.panel1.Controls.Add(this.btnPrsnlIslemler);
            this.panel1.Controls.Add(this.BtnTkmIslemleri);
            this.panel1.Controls.Add(this.buttobtnMngrIslemleri);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 563);
            this.panel1.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::personelYonetimi.Properties.Resources.dept;
            this.pictureBox1.Location = new System.Drawing.Point(52, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // btnDepİslemler
            // 
            this.btnDepİslemler.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDepİslemler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDepİslemler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDepİslemler.Location = new System.Drawing.Point(0, 170);
            this.btnDepİslemler.Name = "btnDepİslemler";
            this.btnDepİslemler.Size = new System.Drawing.Size(200, 69);
            this.btnDepİslemler.TabIndex = 58;
            this.btnDepİslemler.Text = "Departman İşlemleri";
            this.btnDepİslemler.UseVisualStyleBackColor = false;
            this.btnDepİslemler.Click += new System.EventHandler(this.btnDepİslemler_Click);
            // 
            // btnPrsnlIslemler
            // 
            this.btnPrsnlIslemler.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPrsnlIslemler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrsnlIslemler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrsnlIslemler.Location = new System.Drawing.Point(0, 245);
            this.btnPrsnlIslemler.Name = "btnPrsnlIslemler";
            this.btnPrsnlIslemler.Size = new System.Drawing.Size(200, 67);
            this.btnPrsnlIslemler.TabIndex = 57;
            this.btnPrsnlIslemler.Text = "Personel İşlemleri";
            this.btnPrsnlIslemler.UseVisualStyleBackColor = false;
            this.btnPrsnlIslemler.Click += new System.EventHandler(this.btnPrsnlIslemler_Click);
            // 
            // BtnTkmIslemleri
            // 
            this.BtnTkmIslemleri.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnTkmIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTkmIslemleri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnTkmIslemleri.Location = new System.Drawing.Point(0, 318);
            this.BtnTkmIslemleri.Name = "BtnTkmIslemleri";
            this.BtnTkmIslemleri.Size = new System.Drawing.Size(200, 67);
            this.BtnTkmIslemleri.TabIndex = 59;
            this.BtnTkmIslemleri.Text = "Takım İşlemleri";
            this.BtnTkmIslemleri.UseVisualStyleBackColor = false;
            this.BtnTkmIslemleri.Click += new System.EventHandler(this.BtnTkmIslemleri_Click);
            // 
            // buttobtnMngrIslemleri
            // 
            this.buttobtnMngrIslemleri.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttobtnMngrIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttobtnMngrIslemleri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttobtnMngrIslemleri.Location = new System.Drawing.Point(0, 391);
            this.buttobtnMngrIslemleri.Name = "buttobtnMngrIslemleri";
            this.buttobtnMngrIslemleri.Size = new System.Drawing.Size(200, 71);
            this.buttobtnMngrIslemleri.TabIndex = 60;
            this.buttobtnMngrIslemleri.Text = "Yönetici İşlemleri";
            this.buttobtnMngrIslemleri.UseVisualStyleBackColor = false;
            this.buttobtnMngrIslemleri.Click += new System.EventHandler(this.btnMngrIslemleri_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(200, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 91);
            this.panel2.TabIndex = 66;
            // 
            // DeptIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(803, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridPersonel);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeptIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deptİslemleri";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEPARTMENTBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeptSil;
        private System.Windows.Forms.Button btnDeptGuncelle;
        private System.Windows.Forms.DataGridView dataGridPersonel;
        private testdbDataSet1 testdbDataSet1;
        private System.Windows.Forms.BindingSource dEPARTMENTBindingSource;
        private testdbDataSet1TableAdapters.DEPARTMENTTableAdapter dEPARTMENTTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDepİslemler;
        private System.Windows.Forms.Button btnPrsnlIslemler;
        private System.Windows.Forms.Button BtnTkmIslemleri;
        private System.Windows.Forms.Button buttobtnMngrIslemleri;
        private System.Windows.Forms.Panel panel2;
    }
}