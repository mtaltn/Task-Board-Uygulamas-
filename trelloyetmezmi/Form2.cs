using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trelloyetmezmi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tekknik fr = new tekknik();

            fr.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView10.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView10.Rows[i];
                if (Convert.ToBoolean(row.Cells["ikincisec"].Value))
                {
                    gorevler2BindingSource.Add((gorevler5)row.DataBoundItem);
                    gorevler5BindingSource.Remove(row.DataBoundItem);
                }

            }
        }
        trelloEntities1 db = new trelloEntities1();
        private void btnyenigorev_Click(object sender, EventArgs e)
        {
            gorevler5 ekle = new gorevler5();
            ekle.gorev = textBox1.Text;
            db.gorevler5.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("YENİ GÖREVİNİZ KUTLU OLSUN. TANRI BU GÖREVDE YAR VE YARDIMCINIZ OLSUN.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            gorevler5BindingSource.DataSource = db.gorevler5.ToList();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView10.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView10.Rows[i];
                if (Convert.ToBoolean(row.Cells["birincisec"].Value))
                {
                    gorevler5BindingSource.Add((gorevler)row.DataBoundItem);
                    gorevler2BindingSource.Remove(row.DataBoundItem);
                }

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gorevler5BindingSource.DataSource = db.gorevler5.ToList();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int gorevIdd = Convert.ToInt32(textBox3.Text);

            var sil = db.gorevler5.Where(w => w.gorevId == gorevIdd).FirstOrDefault();
            db.gorevler5.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("GÖREVİNİZ Silindi.(Hadi Yine İyisiniz.)");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            gorevler5BindingSource.DataSource = db.gorevler.ToList();
        }

        private void dataGridView10_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView10.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView10.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int gorevIdd = Convert.ToInt32(textBox3.Text);
            var güncelle = db.gorevler5.Where(w => w.gorevId == gorevIdd).FirstOrDefault();
            güncelle.gorev = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("GÖREVİNİZ GÜNCELLENDİ.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            gorevler5BindingSource.DataSource = db.gorevler5.ToList();
        }
    }
}
