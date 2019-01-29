using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cute_Cats
{
    public Bitmap[] cats = {
        CatRes.c1,
        CatRes.c2,
        CatRes.c3,
        CatRes.c4,
        CatRes.c5,
        CatRes.c6,
        CatRes.c7
    };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(new frmImages().Show);
        }
    }
}
