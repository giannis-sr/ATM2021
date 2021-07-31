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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "1234")
            {
                Menu m = new Menu(); //εμφανηση του νεου παραθυρου
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Το PIN που πληκτρολογησατε ειναι Λανθασμενο παρακαλω προσπαθηστε ξανα.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
