using System.Windows.Forms;
namespace WinFormsApp14
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Register r = new Register();
            r.Show();
            Hide();
          
        }


        public void setData(string userName , string pass)
        {
            textBox2.Text = userName;
            textBox1.Text = pass;
        }


        private void button1_Click(object sender, System.EventArgs e)
        {
            string email = textBox2.Text;
            string pass = textBox1.Text;

            if (email  == "test" && pass == "123")
            {
                Home h = new Home(email);
                h.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invaild user name or password");
            }
        }
    }
}
