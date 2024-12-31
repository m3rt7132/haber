namespace haber
{
    partial class GirisForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            kAdiBox = new TextBox();
            sifreBox = new TextBox();
            girisButton = new Button();
            kayitYonlendir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 0;
            label1.Text = "Haber";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(68, 79);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(68, 137);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 2;
            label3.Text = "Şifre";
            // 
            // kAdiBox
            // 
            kAdiBox.Location = new Point(220, 84);
            kAdiBox.Name = "kAdiBox";
            kAdiBox.Size = new Size(247, 23);
            kAdiBox.TabIndex = 3;
            // 
            // sifreBox
            // 
            sifreBox.Location = new Point(220, 142);
            sifreBox.Name = "sifreBox";
            sifreBox.Size = new Size(247, 23);
            sifreBox.TabIndex = 4;
            // 
            // girisButton
            // 
            girisButton.BackColor = Color.FromArgb(0, 192, 0);
            girisButton.FlatStyle = FlatStyle.Flat;
            girisButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            girisButton.ForeColor = Color.Black;
            girisButton.Location = new Point(220, 198);
            girisButton.Name = "girisButton";
            girisButton.Size = new Size(247, 51);
            girisButton.TabIndex = 5;
            girisButton.Text = "Giriş Yap!";
            girisButton.UseVisualStyleBackColor = false;
            girisButton.Click += girisButton_Click;
            // 
            // kayitYonlendir
            // 
            kayitYonlendir.BackColor = Color.LimeGreen;
            kayitYonlendir.FlatStyle = FlatStyle.Flat;
            kayitYonlendir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            kayitYonlendir.Location = new Point(483, 10);
            kayitYonlendir.Name = "kayitYonlendir";
            kayitYonlendir.Size = new Size(97, 40);
            kayitYonlendir.TabIndex = 13;
            kayitYonlendir.Text = "Kayıt Formu";
            kayitYonlendir.UseVisualStyleBackColor = false;
            kayitYonlendir.Click += kayitYonlendir_Click;
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(592, 327);
            Controls.Add(kayitYonlendir);
            Controls.Add(girisButton);
            Controls.Add(sifreBox);
            Controls.Add(kAdiBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GirisForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox kAdiBox;
        private TextBox sifreBox;
        private Button girisButton;
        private Button kayitYonlendir;
    }
}