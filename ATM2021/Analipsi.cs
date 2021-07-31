using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM2021
{
    public partial class Analipsi : Form
    {
        public Analipsi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool res = ATM.withdraw(Double.Parse(textBox1.Text));

            if (res == true)
                MessageBox.Show("Η αναληψη των μετρητων πραγματοποιηθηκε");
            else
                MessageBox.Show("Παρουσιαστηκε καποιο προβλημα δοκιμαστε ξανα");
        }
    }
}
