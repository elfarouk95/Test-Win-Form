using System.Windows.Forms;

namespace WinFormsApp14
{
    public partial class Home : Form
    {
        public Home(string name)
        {
            InitializeComponent();

            label1.Text = "Hello " + name;
        }


        private void Home_Load(object sender, System.EventArgs e)
        {
          
        }
    }
}
