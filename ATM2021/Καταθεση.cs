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
    public partial class Καταθεση : Form
    {
        //ATM a = new ATM();
        public Καταθεση()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATM.Deposit(double.Parse(textBox1.Text));

            MessageBox.Show("Η καταθεση του ποσου των " + textBox1.Text + "Ευρω πραγματοποιηθηκε με επτυχια");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }
    }
}
