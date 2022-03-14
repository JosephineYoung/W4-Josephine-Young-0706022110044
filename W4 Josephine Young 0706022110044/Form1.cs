using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4_Josephine_Young_0706022110044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int counter = 0;
        public static int counterArray = 11;
        public static string[] dataNama = new string[counterArray];
        public static string[] dataAlamat = new string[counterArray];
        public static string[] dataTelp = new string[counterArray];

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            dataNama[counter - 1] = tBoxNama.Text;
            dataAlamat[counter - 1] = tBoxAlamat.Text;
            dataTelp[counter - 1] = tBoxTelp.Text;
            tBoxNama.Text = "";
            tBoxAlamat.Text = "";
            tBoxTelp.Text = "";
            if (counter > 10)
            {
                MessageBox.Show("Data telah penuh!");
                counter = counter - 1;
            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            Form2 formData = new Form2();
            Form1 frommain = new Form1();
            formData.Show();
            this.Hide();
        }

        private void tBoxTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char numbTelp = e.KeyChar;
            if (!Char.IsDigit(numbTelp) && numbTelp != 8)
            {
                e.Handled = true;
            }
        }
    }
}
