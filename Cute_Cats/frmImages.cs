using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cute_Cats
{
    public partial class frmImages : Form
    {
        MassiveHelper mh = new MassiveHelper();
        int select = 0;
        public frmImages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (select != 0) select -= 1;
            ThatsRefreshing();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (select < (mh.cats.Length - 1)) select += 1;
            ThatsRefreshing();
        }

        public void ThatsRefreshing() {
            label1.Text = (select + 1).ToString()+" of "+mh.cats.Length;
            pictureBox1.Image = mh.cats[select];
            pictureBox1.Update();
        }

        private void frmImages_Load(object sender, EventArgs e)
        {
            ThatsRefreshing();
        }
    }
}
