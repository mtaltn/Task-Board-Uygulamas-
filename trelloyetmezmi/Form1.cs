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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView3.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView3.Rows[i];
                if (Convert.ToBoolean(row.Cells["ikincisec"].Value))
                {
                    gorevlerBindingSource1.Add((gorevler)row.DataBoundItem);
                    gorevlerBindingSource.Remove(row.DataBoundItem);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView2.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView2.Rows[i];
                if (Convert.ToBoolean(row.Cells["birincisec"].Value))
                {
                    gorevlerBindingSource.Add((gorevler)row.DataBoundItem);
                    gorevlerBindingSource1.Remove(row.DataBoundItem);
                }

            }
        }
        trelloEntities db = new trelloEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            gorevlerBindingSource1.DataSource = db.gorevler.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView3.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView3.Rows[i];
                if (Convert.ToBoolean(row.Cells["ikincisec"].Value))
                {
                    gorevlerBindingSource2.Add((gorevler)row.DataBoundItem);
                    gorevlerBindingSource.Remove(row.DataBoundItem);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (Convert.ToBoolean(row.Cells["ucuncusec"].Value))
                {
                    gorevlerBindingSource3.Add((gorevler)row.DataBoundItem);
                    gorevlerBindingSource2.Remove(row.DataBoundItem);
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView4.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView4.Rows[i];
                if (Convert.ToBoolean(row.Cells["dorduncusec"].Value))
                {
                    gorevlerBindingSource4.Add((gorevler)row.DataBoundItem);
                    gorevlerBindingSource3.Remove(row.DataBoundItem);
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (Convert.ToBoolean(row.Cells["ucuncusec"].Value))
                {
                    gorevlerBindingSource.Add((gorevler)row.DataBoundItem);
                    gorevlerBindingSource2.Remove(row.DataBoundItem);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView4.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView4.Rows[i];
                if (Convert.ToBoolean(row.Cells["dorduncusec"].Value))
                {
                    gorevlerBindingSource2.Add((gorevler)row.DataBoundItem);
                    gorevlerBindingSource3.Remove(row.DataBoundItem);
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView5.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView5.Rows[i];
                if (Convert.ToBoolean(row.Cells["besincisec"].Value))
                {
                    gorevlerBindingSource3.Add((gorevler)row.DataBoundItem);
                    gorevlerBindingSource4.Remove(row.DataBoundItem);
                }

            }
        }

        private void btnTeknik_Click(object sender, EventArgs e)
        {
            teknik fr = new teknik();

            fr.ShowDialog();

        }

        private void btnyenigorev_Click(object sender, EventArgs e)
        {
            gorevler ekle = new gorevler();
            ekle.gorev = textBox1.Text;
            db.gorevler.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("YENİ GÖREVİNİZ KUTLU OLSUN. TANRI BU GÖREVDE YAR VE YARDIMCINIZ OLSUN.");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            gorevlerBindingSource1.DataSource = db.gorevler.ToList();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int gorevIdd = Convert.ToInt32(textBox3.Text);
            var güncelle = db.gorevler.Where(w => w.gorevId == gorevIdd).FirstOrDefault();
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

            gorevlerBindingSource1.DataSource = db.gorevler.ToList();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();

        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView5.CurrentRow.Cells[0].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int gorevIdd = Convert.ToInt32(textBox3.Text);
            
            var sil = db.gorevler.Where(w => w.gorevId == gorevIdd).FirstOrDefault();
            db.gorevler.Remove(sil);
            db.SaveChanges();
            MessageBox.Show("GÖREVİNİZ Silindi.(Hadi Yine İyisiniz.)");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            gorevlerBindingSource1.DataSource = db.gorevler.ToList();
        }
    }
}
