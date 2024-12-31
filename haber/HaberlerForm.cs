using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace haber
{
    public partial class HaberlerForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Pwd=;Database=haber";
        bool isAdmin = false;
        bool girisli = false;

        public HaberlerForm(bool girisli, bool isAdmin)
        {
            InitializeComponent();
            this.girisli = girisli;
            this.isAdmin = isAdmin;
            if (isAdmin) adminPnlBtn.Visible = true;
            else adminPnlBtn.Visible = false;
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.girisli = false;
            this.isAdmin = false;
            GirisForm girisForm = new();
            girisForm.Show();
            this.Hide();
        }

        private void adminPnlBtn_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new();
            adminPanel.Show();
            this.Hide();
        }

        private void HaberleriListele(string kategori)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query;
                    if (kategori == "" || kategori == "Hepsi") query = "SELECT Baslik, Icerik, Kategori, Resim, EklenmeTarihi FROM haberler";
                    else if (kategori != "") query = $"SELECT Baslik, Icerik, Kategori, Resim, EklenmeTarihi FROM haberler WHERE Kategori='{kategori}'";
                    else query = "SELECT Baslik, Icerik, Kategori, Resim, EklenmeTarihi FROM haberler";

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

                            Image image;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                image = Image.FromStream(ms);
                            }

                            Panel haberPanel = new Panel
                            {
                                Width = 830,
                                Height = 250,
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            PictureBox pictureBox = new PictureBox
                            {
                                Image = image,
                                Width = 250,
                                Height = 250,
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
                                Padding = new Padding(10),
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
                            haberPanel.Controls.Add(lblDate);
                            haberPanel.Controls.Add(lblCategory);
                            haberPanel.Controls.Add(lblDescription);
                            haberPanel.Controls.Add(lblTitle);
                            haberPanel.Controls.Add(pictureBox);

                            haberlerLayout.Controls.Add(haberPanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Haberleri yüklerken bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HaberlerForm_Load(object sender, EventArgs e)
        {
            haberlerLayout.Controls.Clear();
            HaberleriListele("");
            FotoGaleriYukle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            haberlerLayout.Controls.Clear();
            HaberleriListele(comboBox1.Text);
        }

        private void FotoGaleriYukle()
        {
            fotogaleriLayout.Controls.Clear();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Resim FROM haberler";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                byte[] imageBytes = (byte[])reader["Resim"];
                                using (var ms = new MemoryStream(imageBytes))
                                {
                                    Image image = Image.FromStream(ms);

                                    PictureBox pictureBox = new PictureBox
                                    {
                                        Image = image,
                                        Width = 340,
                                        Height = 240,
                                        SizeMode = PictureBoxSizeMode.StretchImage,
                                        Margin = new Padding(10),
                                        BorderStyle = BorderStyle.FixedSingle,
                                    };

                                    fotogaleriLayout.Controls.Add(pictureBox);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
