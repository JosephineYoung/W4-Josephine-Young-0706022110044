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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int counter2 = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            tBoxAlamat2.Enabled = false;
            tBoxNama2.Enabled = false;
            tBoxTelp2.Enabled = false;
            tBoxAlamat2.Text = Form1.dataAlamat[0];
            tBoxNama2.Text = Form1.dataNama[0];
            tBoxTelp2.Text = Form1.dataTelp[0];
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnPrevData_Click(object sender, EventArgs e)
        {
            counter2 = counter2 - 1;
            if(counter2 < 0)
            {
                MessageBox.Show("Data sudah data pertama");
                counter2 = counter2 + 1;
            }
            tBoxAlamat2.Text = Form1.dataAlamat[counter2];
            tBoxNama2.Text = Form1.dataNama[counter2];
            tBoxTelp2.Text = Form1.dataTelp[counter2];
        }

        private void btnNextData_Click(object sender, EventArgs e)
        {
            counter2 = counter2 + 1;
            if(counter2 >= 10)
            {
                MessageBox.Show("Data sudah data terakhir");
                counter2 = counter2 - 1;
            }
            tBoxAlamat2.Text = Form1.dataAlamat[counter2];
            tBoxNama2.Text = Form1.dataNama[counter2];
            tBoxTelp2.Text = Form1.dataTelp[counter2];
        }
    }
}
