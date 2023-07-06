namespace örnek_otomasyon
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridView1 = new DataGridView();
            colum1 = new DataGridViewTextBoxColumn();
            Colum2 = new DataGridViewTextBoxColumn();
            Colum3 = new DataGridViewTextBoxColumn();
            Colum4 = new DataGridViewTextBoxColumn();
            btnsil = new DataGridViewButtonColumn();
            ekle = new Button();
            button3 = new Button();
            urunadi = new TextBox();
            fiyat = new TextBox();
            adet = new TextBox();
            sonuc = new GroupBox();
            txttoplam = new TextBox();
            txtkdv = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtaratoplam = new TextBox();
            checkBox1 = new CheckBox();
            dataGridView2 = new DataGridView();
            aratoplam = new DataGridViewTextBoxColumn();
            kdv = new DataGridViewTextBoxColumn();
            geneltoplam = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            sonuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            DataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { colum1, Colum2, Colum3, Colum4, btnsil });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            DataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            DataGridView1.Location = new Point(12, 94);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.RowTemplate.Height = 25;
            DataGridView1.RowTemplate.ReadOnly = true;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DataGridView1.Size = new Size(783, 512);
            DataGridView1.TabIndex = 0;
            DataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colum1
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            colum1.DefaultCellStyle = dataGridViewCellStyle1;
            colum1.FillWeight = 322.684357F;
            colum1.HeaderText = "Ürün Adı";
            colum1.Name = "colum1";
            colum1.ReadOnly = true;
            // 
            // Colum2
            // 
            Colum2.FillWeight = 33.7025871F;
            Colum2.HeaderText = "Ürün Fiyat";
            Colum2.Name = "Colum2";
            Colum2.ReadOnly = true;
            // 
            // Colum3
            // 
            Colum3.FillWeight = 33.7025871F;
            Colum3.HeaderText = "Ürün Adet";
            Colum3.Name = "Colum3";
            Colum3.ReadOnly = true;
            // 
            // Colum4
            // 
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Colum4.DefaultCellStyle = dataGridViewCellStyle2;
            Colum4.FillWeight = 33.7025871F;
            Colum4.HeaderText = "Toplam Tutar";
            Colum4.Name = "Colum4";
            Colum4.ReadOnly = true;
            // 
            // btnsil
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Cyan;
            dataGridViewCellStyle3.ForeColor = Color.Red;
            btnsil.DefaultCellStyle = dataGridViewCellStyle3;
            btnsil.HeaderText = "SIL";
            btnsil.Name = "btnsil";
            btnsil.ReadOnly = true;
            btnsil.Text = "SIL";
            btnsil.ToolTipText = "SIL";
            btnsil.UseColumnTextForButtonValue = true;
            // 
            // ekle
            // 
            ekle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ekle.Location = new Point(835, 41);
            ekle.Name = "ekle";
            ekle.Size = new Size(365, 71);
            ekle.TabIndex = 4;
            ekle.Text = "EKLE";
            ekle.UseVisualStyleBackColor = true;
            ekle.Click += ekle_Click;
            ekle.Enter += Form1_Load;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(835, 356);
            button3.Name = "button3";
            button3.Size = new Size(365, 71);
            button3.TabIndex = 6;
            button3.Text = "PDF ÇIKTI AL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // urunadi
            // 
            urunadi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            urunadi.Location = new Point(12, 41);
            urunadi.Name = "urunadi";
            urunadi.PlaceholderText = "Ürün Adı";
            urunadi.Size = new Size(416, 33);
            urunadi.TabIndex = 8;
            // 
            // fiyat
            // 
            fiyat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            fiyat.Location = new Point(434, 41);
            fiyat.Name = "fiyat";
            fiyat.PlaceholderText = "Birim Fiyat";
            fiyat.Size = new Size(182, 33);
            fiyat.TabIndex = 9;
            fiyat.KeyPress += fiyat_KeyPress;
            // 
            // adet
            // 
            adet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            adet.Location = new Point(622, 41);
            adet.Name = "adet";
            adet.PlaceholderText = "Ürün Adet";
            adet.Size = new Size(173, 33);
            adet.TabIndex = 10;
            adet.KeyPress += adet_KeyPress;
            // 
            // sonuc
            // 
            sonuc.Controls.Add(txttoplam);
            sonuc.Controls.Add(txtkdv);
            sonuc.Controls.Add(label3);
            sonuc.Controls.Add(label2);
            sonuc.Controls.Add(label1);
            sonuc.Controls.Add(txtaratoplam);
            sonuc.Location = new Point(835, 118);
            sonuc.Name = "sonuc";
            sonuc.Size = new Size(365, 181);
            sonuc.TabIndex = 11;
            sonuc.TabStop = false;
            sonuc.Text = "SONUÇ";
            // 
            // txttoplam
            // 
            txttoplam.BackColor = Color.Gainsboro;
            txttoplam.BorderStyle = BorderStyle.None;
            txttoplam.Enabled = false;
            txttoplam.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txttoplam.Location = new Point(155, 127);
            txttoplam.Name = "txttoplam";
            txttoplam.Size = new Size(194, 26);
            txttoplam.TabIndex = 5;
            // 
            // txtkdv
            // 
            txtkdv.BackColor = Color.Gainsboro;
            txtkdv.BorderStyle = BorderStyle.None;
            txtkdv.Enabled = false;
            txtkdv.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtkdv.Location = new Point(155, 81);
            txtkdv.Name = "txtkdv";
            txtkdv.Size = new Size(194, 26);
            txtkdv.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 127);
            label3.Name = "label3";
            label3.Size = new Size(97, 30);
            label3.TabIndex = 3;
            label3.Text = "Toplam :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 2;
            label2.Text = "KDV(%18) :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 1;
            label1.Text = "Ara Toplam : ";
            // 
            // txtaratoplam
            // 
            txtaratoplam.BackColor = Color.Gainsboro;
            txtaratoplam.BorderStyle = BorderStyle.None;
            txtaratoplam.Enabled = false;
            txtaratoplam.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtaratoplam.Location = new Point(155, 34);
            txtaratoplam.Name = "txtaratoplam";
            txtaratoplam.Size = new Size(194, 26);
            txtaratoplam.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(835, 315);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(143, 25);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "KDV";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { aratoplam, kdv, geneltoplam });
            dataGridView2.Location = new Point(12, 612);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(783, 56);
            dataGridView2.TabIndex = 13;
            // 
            // aratoplam
            // 
            aratoplam.HeaderText = "Ara Toplam";
            aratoplam.Name = "aratoplam";
            aratoplam.ReadOnly = true;
            // 
            // kdv
            // 
            kdv.HeaderText = "KDV (%18)";
            kdv.Name = "kdv";
            kdv.ReadOnly = true;
            // 
            // geneltoplam
            // 
            geneltoplam.HeaderText = "Toplam";
            geneltoplam.Name = "geneltoplam";
            geneltoplam.ReadOnly = true;
            // 
            // Form1
            // 
            AcceptButton = ekle;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1224, 680);
            Controls.Add(dataGridView2);
            Controls.Add(checkBox1);
            Controls.Add(sonuc);
            Controls.Add(adet);
            Controls.Add(fiyat);
            Controls.Add(urunadi);
            Controls.Add(button3);
            Controls.Add(ekle);
            Controls.Add(DataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "FİYAT LİSTESİ OLUŞTURUCU";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            sonuc.ResumeLayout(false);
            sonuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView1;
        private TextBox urunadi;
        private TextBox urunfiyat;
        private TextBox urunadet;
        private Button ekle;
        private Button button2;
        private Button button3;
        private TextBox txtaratoplam;
        private TextBox fiyat;
        private TextBox adet;
        private GroupBox sonuc;
        private Label label1;
        private TextBox txttoplam;
        private TextBox txtkdv;
        private Label label3;
        private Label label2;
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn colum1;
        private DataGridViewTextBoxColumn Colum2;
        private DataGridViewTextBoxColumn Colum3;
        private DataGridViewTextBoxColumn Colum4;
        private DataGridViewButtonColumn btnsil;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn aratoplam;
        private DataGridViewTextBoxColumn kdv;
        private DataGridViewTextBoxColumn geneltoplam;
    }
}