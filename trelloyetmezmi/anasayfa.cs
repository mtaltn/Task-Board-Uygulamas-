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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void btnprofil_Click(object sender, EventArgs e)
        {
            hesabim fr = new hesabim();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            this.Visible = false;
            fr.ShowDialog();
            this.Visible = true;
        }
    }
}
