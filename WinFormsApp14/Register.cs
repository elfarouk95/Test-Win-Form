using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp14
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();

            string userName = textBox2.Text;
            string pass = textBox1.Text;

            l.setData(userName, pass);

            l.Show();
            Hide();
        }
    }
}
