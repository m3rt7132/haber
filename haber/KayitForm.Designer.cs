namespace haber
{
    partial class KayitForm
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
            kayitButton = new Button();
            sifreBox = new TextBox();
            kAdiBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            girisYonlendir = new Button();
            SuspendLayout();
            // 
            // kayitButton
            // 
            kayitButton.BackColor = Color.FromArgb(0, 192, 0);
            kayitButton.FlatStyle = FlatStyle.Flat;
            kayitButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Italic);
            kayitButton.ForeColor = Color.Black;
            kayitButton.Location = new Point(211, 227);
            kayitButton.Name = "kayitButton";
            kayitButton.Size = new Size(247, 51);
            kayitButton.TabIndex = 11;
            kayitButton.Text = "Kayıt Ol!";
            kayitButton.UseVisualStyleBackColor = false;
            kayitButton.Click += kayitButton_Click;
            // 
            // sifreBox
            // 
            sifreBox.Location = new Point(211, 171);
            sifreBox.Name = "sifreBox";
            sifreBox.Size = new Size(247, 23);
            sifreBox.TabIndex = 10;
            // 
            // kAdiBox
            // 
            kAdiBox.Location = new Point(211, 113);
            kAdiBox.Name = "kAdiBox";
            kAdiBox.Size = new Size(247, 23);
            kAdiBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(59, 166);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 8;
            label3.Text = "Şifre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(59, 108);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 7;
            label2.Text = "Kullanıcı adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(244, 38);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 6;
            label1.Text = "Haber";
            // 
            // girisYonlendir
            // 
            girisYonlendir.BackColor = Color.LimeGreen;
            girisYonlendir.FlatStyle = FlatStyle.Flat;
            girisYonlendir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            girisYonlendir.Location = new Point(435, 12);
            girisYonlendir.Name = "girisYonlendir";
            girisYonlendir.Size = new Size(97, 40);
            girisYonlendir.TabIndex = 12;
            girisYonlendir.Text = "Giriş Formu";
            girisYonlendir.UseVisualStyleBackColor = false;
            girisYonlendir.Click += girisYonlendir_Click;
            // 
            // KayitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 332);
            Controls.Add(girisYonlendir);
            Controls.Add(kayitButton);
            Controls.Add(sifreBox);
            Controls.Add(kAdiBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KayitForm";
            Text = "KayitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button kayitButton;
        private TextBox sifreBox;
        private TextBox kAdiBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button girisYonlendir;
    }
}