namespace haber
{
    partial class HaberlerForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            haberlerLayout = new FlowLayoutPanel();
            label1 = new Label();
            cikisBtn = new Button();
            adminPnlBtn = new Button();
            comboBox1 = new ComboBox();
            tabPage2 = new TabPage();
            fotogaleriLayout = new FlowLayoutPanel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tabControl1.Location = new Point(2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(884, 452);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(haberlerLayout);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cikisBtn);
            tabPage1.Controls.Add(adminPnlBtn);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(876, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Haberler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // haberlerLayout
            // 
            haberlerLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            haberlerLayout.AutoScroll = true;
            haberlerLayout.Font = new Font("Roboto", 10F, FontStyle.Bold);
            haberlerLayout.Location = new Point(6, 38);
            haberlerLayout.Name = "haberlerLayout";
            haberlerLayout.Size = new Size(864, 378);
            haberlerLayout.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 1;
            label1.Text = "Kategori seç";
            // 
            // cikisBtn
            // 
            cikisBtn.BackColor = Color.Red;
            cikisBtn.FlatStyle = FlatStyle.Flat;
            cikisBtn.Location = new Point(757, 3);
            cikisBtn.Name = "cikisBtn";
            cikisBtn.Size = new Size(113, 29);
            cikisBtn.TabIndex = 0;
            cikisBtn.Text = "Çıkış Yap";
            cikisBtn.UseVisualStyleBackColor = false;
            cikisBtn.Click += cikisBtn_Click;
            // 
            // adminPnlBtn
            // 
            adminPnlBtn.BackColor = Color.FromArgb(0, 192, 0);
            adminPnlBtn.FlatStyle = FlatStyle.Flat;
            adminPnlBtn.Location = new Point(629, 3);
            adminPnlBtn.Name = "adminPnlBtn";
            adminPnlBtn.Size = new Size(122, 29);
            adminPnlBtn.TabIndex = 1;
            adminPnlBtn.Text = "Admin Panel";
            adminPnlBtn.UseVisualStyleBackColor = false;
            adminPnlBtn.Click += adminPnlBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hepsi", "Gündem", "Teknoloji", "Spor", "Sağlık", "Ekonomi" });
            comboBox1.Location = new Point(99, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(fotogaleriLayout);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(876, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Foto Galeri";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // fotogaleriLayout
            // 
            fotogaleriLayout.AutoScroll = true;
            fotogaleriLayout.Location = new Point(0, 0);
            fotogaleriLayout.Name = "fotogaleriLayout";
            fotogaleriLayout.Size = new Size(876, 416);
            fotogaleriLayout.TabIndex = 0;
            // 
            // HaberlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(889, 467);
            Controls.Add(tabControl1);
            Name = "HaberlerForm";
            Text = "Form1";
            Load += HaberlerForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private ComboBox comboBox1;
        private Button adminPnlBtn;
        private Button cikisBtn;
        private FlowLayoutPanel haberlerLayout;
        private TabPage tabPage2;
        private FlowLayoutPanel fotogaleriLayout;
    }
}
