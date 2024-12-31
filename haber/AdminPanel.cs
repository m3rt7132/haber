using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haber
{
    public partial class AdminPanel : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=;Database=haber";
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            HaberlerForm haberlerForm = new(true, true);
            haberlerForm.Show();
            this.Hide();
        }

        private void resimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Bir resim seçin"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void haberEkle_Click(object sender, EventArgs e)
        {
            string title = txtBaslik.Text.Trim();
            string description = icerik.Text.Trim();
            string category = cmbKategori.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(category) || pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun ve bir resim seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                byte[] imageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                    imageBytes = ms.ToArray();
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO haberler (Baslik, Icerik, Kategori, Resim) VALUES (@baslik, @icerik, @kategori, @resim)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@baslik", title);
                        cmd.Parameters.AddWithValue("@icerik", description);
                        cmd.Parameters.AddWithValue("@kategori", category);
                        cmd.Parameters.AddWithValue("@resim", imageBytes);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Haber başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtBaslik.Clear();
                        icerik.Clear();
                        cmbKategori.SelectedIndex = -1;
                        pictureBox1.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void UyeleriGetir()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM users";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Panel userPanel = new Panel
                            {
                                Width = 800,
                                Height = 50,
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            Label kAdiLabel = new Label
                            {
                                Text = $"Üye adı: {reader["KullaniciAdi"].ToString()}",
                                Font = new Font("Roboto", 13, FontStyle.Bold),
                                Dock = DockStyle.Left,
                                Padding = new Padding(5),
                                AutoSize = true
                            };

                            Label lblAdmin = new Label
                            {
                                Text = "Üye tipi: " + (Convert.ToBoolean(reader["isAdmin"]) ? "Admin" : "Üye"),
                                Font = new Font("Roboto", 13, FontStyle.Bold),
                                Dock = DockStyle.Left,
                                Padding = new Padding(5),
                                AutoSize = true
                            };

                            Button btnOnayla = new Button
                            {
                                Text = Convert.ToBoolean(reader["Onay"]) ? "Zaten Onaylı" : "Onayla",
                                BackColor = Convert.ToBoolean(reader["Onay"]) ? Color.Gray : Color.LimeGreen,
                                Enabled = Convert.ToBoolean(reader["Onay"]) ? false : true,
                                Width = 130,
                                Height = 40,
                                FlatStyle = FlatStyle.Flat,
                                Dock = DockStyle.Right,
                                Padding = new Padding(5),
                                Tag = Convert.ToInt32(reader["UserID"])
                            };
                            btnOnayla.Click += (s, e) =>
                            {
                                Button btn = s as Button;
                                int userId = (int)btn.Tag;

                                using (MySqlConnection conn = new MySqlConnection(connectionString))
                                {
                                    conn.Open();
                                    string query = "UPDATE users SET Onay = 1 WHERE UserID = @userId";

                                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@userId", userId);
                                        cmd.ExecuteNonQuery();
                                    }
                                    MessageBox.Show("Üye onaylandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            };

                            Button uyeSilBtn = new Button
                            {
                                Text = "Sil",
                                BackColor = Color.Red,
                                Width = 130,
                                Height = 40,
                                FlatStyle = FlatStyle.Flat,
                                Dock = DockStyle.Right,
                                Padding = new Padding(5),
                                Tag = Convert.ToInt32(reader["UserID"])
                            };
                            uyeSilBtn.Click += (s, e) =>
                            {
                                Button btn = s as Button;
                                int userId = (int)btn.Tag;

                                DialogResult ss = MessageBox.Show("Üyeyi silmek istediğinizden emin misiniz?", "Üye Sil", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                                if (ss == DialogResult.Yes)
                                {

                                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                                    {
                                        conn.Open();
                                        string query = "DELETE FROM users WHERE UserID = @userId";

                                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                        {
                                            cmd.Parameters.AddWithValue("@userId", userId);
                                            cmd.ExecuteNonQuery();
                                        }
                                        MessageBox.Show("Üye silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            };

                            Button adminYapBtn = new Button
                            {
                                Text = Convert.ToBoolean(reader["isAdmin"]) ? "Zaten Admin" : "Admin Yap",
                                BackColor = Convert.ToBoolean(reader["isAdmin"]) ? Color.Gray : Color.Orange,
                                Enabled = Convert.ToBoolean(reader["isAdmin"]) ? false : true,
                                Width = 130,
                                Height = 40,
                                FlatStyle = FlatStyle.Flat,
                                Dock = DockStyle.Right,
                                Padding = new Padding(5),
                                Tag = Convert.ToInt32(reader["UserID"])
                            };
                            adminYapBtn.Click += (s, e) =>
                            {
                                Button btn = s as Button;
                                int userId = (int)btn.Tag;

                                using (MySqlConnection conn = new MySqlConnection(connectionString))
                                {
                                    conn.Open();
                                    string query = "UPDATE users SET isAdmin = 1 WHERE UserID = @userId";

                                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@userId", userId);
                                        cmd.ExecuteNonQuery();
                                    }
                                    MessageBox.Show("Üye admin yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            };

                            userPanel.Controls.Add(lblAdmin);
                            userPanel.Controls.Add(kAdiLabel);
                            userPanel.Controls.Add(adminYapBtn);
                            userPanel.Controls.Add(uyeSilBtn);
                            userPanel.Controls.Add(btnOnayla);

                            unapprovedUsersPanel.Controls.Add(userPanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Haberleri yüklerken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usersYenile_Click(object sender, EventArgs e)
        {
            unapprovedUsersPanel.Controls.Clear();
            UyeleriGetir();
        }

        private void habersilYenileBtn_Click(object sender, EventArgs e)
        {
            HabersilYenile();
        }

        private void HabersilYenile()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT HaberID, Baslik, Icerik, Kategori, Resim, EklenmeTarihi FROM haberler";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string title = reader["Baslik"].ToString();
                            string description = reader["Icerik"].ToString();
                            string category = reader["Kategori"].ToString();
                            byte[] imageBytes = (byte[])reader["Resim"];
                            string date = reader["EklenmeTarihi"].ToString();
                            int haberid = Convert.ToInt32(reader["HaberID"]);

                            Image image;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                image = Image.FromStream(ms);
                            }

                            Panel haberPanel = new Panel
                            {
                                Width = 810,
                                Height = 150,
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            PictureBox pictureBox = new PictureBox
                            {
                                Image = image,
                                Width = 150,
                                Height = 150,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Dock = DockStyle.Left,
                                Margin = new Padding(10)
                            };

                            Label lblTitle = new Label
                            {
                                Text = title,
                                Font = new Font("Roboto", 13, FontStyle.Bold),
                                Dock = DockStyle.Top,
                                Padding = new Padding(5),
                                AutoSize = true
                            };

                            RichTextBox lblDescription = new RichTextBox
                            {
                                Text = description,
                                Font = new Font("Roboto", 11, FontStyle.Regular),
                                Dock = DockStyle.Top,
                                Padding = new Padding(5),
                                AutoSize = true
                            };

                            Label lblCategory = new Label
                            {
                                Text = "Kategori: " + category,
                                Font = new Font("Roboto", 9, FontStyle.Italic),
                                Dock = DockStyle.Top,
                                Padding = new Padding(5),
                                AutoSize = true
                            };

                            Label lblDate = new Label
                            {
                                Text = "Tarih: " + date,
                                Font = new Font("Roboto", 9, FontStyle.Italic),
                                Dock = DockStyle.Top,
                                Padding = new Padding(5),
                                AutoSize = true
                            };
                            Button haberSilBtn = new Button
                            {
                                Text = "Bu haberi sil",
                                BackColor = Color.Red,
                                Width = 130,
                                Height = 40,
                                FlatStyle = FlatStyle.Flat,
                                Dock = DockStyle.Right,
                                Padding = new Padding(5),
                                Tag = haberid
                            };
                            haberSilBtn.Click += (s, e) =>
                            {
                                DialogResult result = MessageBox.Show("Bu haberi silmek istediğinizden emin misiniz?", "Haber Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                if (result == DialogResult.Yes)
                                {
                                    try
                                    {
                                        Button silButton = s as Button;
                                        int haberId = Convert.ToInt32(silButton.Tag);

                                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                                        {
                                            conn.Open();

                                            string query = "DELETE FROM haberler WHERE HaberID = @haberId";

                                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                            {
                                                cmd.Parameters.AddWithValue("@haberId", haberId);
                                                int rowsAffected = cmd.ExecuteNonQuery();

                                                if (rowsAffected > 0)
                                                {
                                                    MessageBox.Show("Haber başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Haber silinemedi. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            };

                            haberPanel.Controls.Add(lblDate);
                            haberPanel.Controls.Add(lblCategory);
                            haberPanel.Controls.Add(lblDescription);
                            haberPanel.Controls.Add(lblTitle);
                            haberPanel.Controls.Add(pictureBox);
                            haberPanel.Controls.Add(haberSilBtn);

                            habersilLayout.Controls.Add(haberPanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Haberleri yüklerken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
