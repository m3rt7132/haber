namespace haber
{
    partial class AdminPanel
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
            geriDon = new Button();
            cmbKategori = new ComboBox();
            label4 = new Label();
            haberEkle = new Button();
            resimSec = new Button();
            pictureBox1 = new PictureBox();
            icerik = new RichTextBox();
            txtBaslik = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            habersilYenileBtn = new Button();
            geridon2 = new Button();
            label6 = new Label();
            habersilLayout = new FlowLayoutPanel();
            tabPage3 = new TabPage();
            geridon3 = new Button();
            usersYenile = new Button();
            unapprovedUsersPanel = new FlowLayoutPanel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // geriDon
            // 
            geriDon.BackColor = Color.LightCoral;
            geriDon.FlatStyle = FlatStyle.Flat;
            geriDon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            geriDon.Location = new Point(719, 412);
            geriDon.Name = "geriDon";
            geriDon.Size = new Size(114, 62);
            geriDon.TabIndex = 0;
            geriDon.Text = "Anasayfa";
            geriDon.UseVisualStyleBackColor = false;
            geriDon.Click += geridon_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Items.AddRange(new object[] { "Gündem", "Teknoloji", "Spor", "Sağlık", "Ekonomi" });
            cmbKategori.Location = new Point(101, 63);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(380, 23);
            cmbKategori.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(19, 288);
            label4.Name = "label4";
            label4.Size = new Size(48, 38);
            label4.TabIndex = 9;
            label4.Text = "Resim\r\nYükle\r\n";
            // 
            // haberEkle
            // 
            haberEkle.BackColor = Color.FromArgb(0, 192, 0);
            haberEkle.FlatStyle = FlatStyle.Flat;
            haberEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            haberEkle.Location = new Point(497, 20);
            haberEkle.Name = "haberEkle";
            haberEkle.Size = new Size(114, 66);
            haberEkle.TabIndex = 8;
            haberEkle.Text = "Haber Ekle";
            haberEkle.UseVisualStyleBackColor = false;
            haberEkle.Click += haberEkle_Click;
            // 
            // resimSec
            // 
            resimSec.BackColor = Color.FromArgb(255, 128, 0);
            resimSec.FlatStyle = FlatStyle.Flat;
            resimSec.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            resimSec.Location = new Point(19, 412);
            resimSec.Name = "resimSec";
            resimSec.Size = new Size(76, 57);
            resimSec.TabIndex = 7;
            resimSec.Text = "Resim Seç";
            resimSec.UseVisualStyleBackColor = false;
            resimSec.Click += resimSec_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(101, 200);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // icerik
            // 
            icerik.Location = new Point(101, 110);
            icerik.Name = "icerik";
            icerik.Size = new Size(380, 74);
            icerik.TabIndex = 4;
            icerik.Text = "";
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(101, 20);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(380, 23);
            txtBaslik.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(19, 64);
            label3.Name = "label3";
            label3.Size = new Size(64, 19);
            label3.TabIndex = 2;
            label3.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(19, 111);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 1;
            label2.Text = "İçerik";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(19, 21);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 0;
            label1.Text = "Başlık";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(847, 509);
            tabControl1.TabIndex = 2;
            tabControl1.TabIndexChanged += tabControl1_TabIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cmbKategori);
            tabPage1.Controls.Add(geriDon);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(haberEkle);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(resimSec);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(icerik);
            tabPage1.Controls.Add(txtBaslik);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(839, 481);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Haber Ekle";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(habersilYenileBtn);
            tabPage2.Controls.Add(geridon2);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(habersilLayout);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(839, 481);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Haber Sil";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // habersilYenileBtn
            // 
            habersilYenileBtn.BackColor = Color.FromArgb(255, 128, 0);
            habersilYenileBtn.FlatStyle = FlatStyle.Flat;
            habersilYenileBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            habersilYenileBtn.Location = new Point(620, 9);
            habersilYenileBtn.Name = "habersilYenileBtn";
            habersilYenileBtn.Size = new Size(107, 44);
            habersilYenileBtn.TabIndex = 3;
            habersilYenileBtn.Text = "Yenile";
            habersilYenileBtn.UseVisualStyleBackColor = false;
            habersilYenileBtn.Click += habersilYenileBtn_Click;
            // 
            // geridon2
            // 
            geridon2.BackColor = Color.LightCoral;
            geridon2.FlatStyle = FlatStyle.Flat;
            geridon2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            geridon2.Location = new Point(733, 9);
            geridon2.Name = "geridon2";
            geridon2.Size = new Size(100, 44);
            geridon2.TabIndex = 2;
            geridon2.Text = "Anasayfa";
            geridon2.UseVisualStyleBackColor = false;
            geridon2.Click += geridon_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 1;
            label6.Text = "Güncel Haberler";
            // 
            // habersilLayout
            // 
            habersilLayout.AutoScroll = true;
            habersilLayout.Location = new Point(6, 59);
            habersilLayout.Name = "habersilLayout";
            habersilLayout.Size = new Size(827, 416);
            habersilLayout.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(geridon3);
            tabPage3.Controls.Add(usersYenile);
            tabPage3.Controls.Add(unapprovedUsersPanel);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(839, 481);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Üye Onayla";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // geridon3
            // 
            geridon3.BackColor = Color.LightCoral;
            geridon3.FlatStyle = FlatStyle.Flat;
            geridon3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            geridon3.Location = new Point(723, 7);
            geridon3.Name = "geridon3";
            geridon3.Size = new Size(100, 44);
            geridon3.TabIndex = 3;
            geridon3.Text = "Anasayfa";
            geridon3.UseVisualStyleBackColor = false;
            geridon3.Click += geridon_Click;
            // 
            // usersYenile
            // 
            usersYenile.BackColor = Color.FromArgb(255, 128, 0);
            usersYenile.FlatStyle = FlatStyle.Flat;
            usersYenile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            usersYenile.Location = new Point(610, 7);
            usersYenile.Name = "usersYenile";
            usersYenile.Size = new Size(107, 44);
            usersYenile.TabIndex = 2;
            usersYenile.Text = "Yenile";
            usersYenile.UseVisualStyleBackColor = false;
            usersYenile.Click += usersYenile_Click;
            // 
            // unapprovedUsersPanel
            // 
            unapprovedUsersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            unapprovedUsersPanel.AutoScroll = true;
            unapprovedUsersPanel.Location = new Point(15, 57);
            unapprovedUsersPanel.Name = "unapprovedUsersPanel";
            unapprovedUsersPanel.Size = new Size(808, 407);
            unapprovedUsersPanel.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.Location = new Point(15, 14);
            label5.Name = "label5";
            label5.Size = new Size(264, 25);
            label5.TabIndex = 0;
            label5.Text = "Onaylanmayı bekleyen üyeler";
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(871, 525);
            Controls.Add(tabControl1);
            Name = "AdminPanel";
            Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button geriDon;
        private PictureBox pictureBox1;
        private RichTextBox icerik;
        private TextBox txtBaslik;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button haberEkle;
        private Button resimSec;
        private ComboBox cmbKategori;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private FlowLayoutPanel unapprovedUsersPanel;
        private Label label5;
        private Button usersYenile;
        private Button geridon2;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button geridon3;
        private FlowLayoutPanel habersilLayout;
        private Button habersilYenileBtn;
    }
}