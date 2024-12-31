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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace haber
{
    public partial class GirisForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=;Database=haber";
        public GirisForm()
        {
            InitializeComponent();
        }
        private void girisButton_Click(object sender, EventArgs e)
        {
            string username = kAdiBox.Text.Trim();
            string password = sifreBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "SELECT isAdmin, Onay FROM users WHERE KullaniciAdi = @username AND Sifre = @password";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    bool isAdmin = Convert.ToBoolean(reader["isAdmin"]);
                                    bool isApproved = Convert.ToBoolean(reader["Onay"]);

                                    if (!isApproved)
                                    {
                                        MessageBox.Show("Hesabınız henüz onaylanmamış. Lütfen bir yönetici ile iletişime geçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    HaberlerForm haberlerForm = new HaberlerForm(true, isAdmin);
                                    haberlerForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void kayitYonlendir_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayitForm kayitForm = new KayitForm();
            kayitForm.Show();
        }

    }
}
