using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace haber
{
    public partial class KayitForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=;Database=haber";
        
        public KayitForm()
        {
            InitializeComponent();
        }

        private void girisYonlendir_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
        }

        private void kayitButton_Click(object sender, EventArgs e)
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

                        string query = "INSERT INTO users (KullaniciAdi, Sifre, isAdmin, Onay) VALUES (@username, @password, @isAdmin, @onay)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@isAdmin", false);
                            cmd.Parameters.AddWithValue("@onay", 0);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Kayıt başarılı! Tekrar giriş yapmadan önce adminlerin üyeliğinizi onaylamasını bekleyin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GirisForm girisFormu = new GirisForm();
                        girisFormu.Show();
                        this.Hide();
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
