using System;
using System.Threading;
using System.Windows.Forms;

namespace Cute_Cats
{
    public partial class Form1 : Form
    {
        MassiveHelper mh = new MassiveHelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmImages().Show();
        }

        private void STFImages() {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
