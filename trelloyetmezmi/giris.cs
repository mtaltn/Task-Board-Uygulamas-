using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trelloyetmezmi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-EUT5D8H;Initial Catalog=trello;Integrated Security=True");
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from login where Ad=@ad and Parola=@parola";
                SqlParameter prm1 = new SqlParameter("ad", txtad.Text.Trim());
                SqlParameter prm2 = new SqlParameter("parola", txtsifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    anasayfa fr = new anasayfa();
                    this.Visible = false;
                    fr.ShowDialog();
                    this.Visible = true;

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anasayfa fr = new anasayfa();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
        }
    }
}
