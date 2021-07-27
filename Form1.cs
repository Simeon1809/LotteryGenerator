using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lottery_Generator
{
    public partial class Form1 : Form
    {
        string iLottery;
        int iStore;
        readonly Random rand = new Random();
        DialogResult iExit;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer7.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            iExit = MessageBox.Show("Confirm Exit From Lottery Game", "Lottery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void btnLottery_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            timer5.Enabled = true;
            timer6.Enabled = true;

            iStore = 30;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            iLottery = Convert.ToString(rnd.Next(1, 100));
            txtLottery1.Text = iLottery;

            if (txtLottery1.Text == "0")
            {
                iLottery = Convert.ToString(rnd.Next(1, 100));
                txtLottery1.Text = iLottery;
            }

            if (txtLottery1.Text == txtLottery2.Text || txtLottery1.Text == txtLottery3.Text || txtLottery1.Text == txtLottery4.Text || txtLottery1.Text == txtLottery5.Text || txtLottery1.Text == txtLottery6.Text)
            {
                iLottery = Convert.ToString(rnd.Next(1, 100));
                txtLottery1.Text = iLottery;
            }
            btnLottery.Enabled = true;

            txtLottery1.BackColor = Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255));
            btnExit.BackColor = Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255));
            btnLottery.BackColor = Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            iLottery = Convert.ToString(rnd.Next(1, 100));
            txtLottery2.Text = iLottery;

            if (txtLottery2.Text == "0")
            {
                iLottery = Convert.ToString(rnd.Next(1, 100));
                txtLottery2.Text = iLottery;
            }

            if (txtLottery2.Text == txtLottery1.Text || txtLottery2.Text == txtLottery3.Text || txtLottery2.Text == txtLottery4.Text || txtLottery2.Text == txtLottery5.Text || txtLottery2.Text == txtLottery6.Text)
            {
                iLottery = Convert.ToString(rnd.Next(1, 100));
                txtLottery2.Text = iLottery;
            }
            btnLottery.Enabled = true;

            txtLottery2.BackColor = Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255));
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            iLottery = Convert.ToString(rnd.Next(1, 100));
            txtLottery3.Text = iLottery;

            if (txtLottery3.Text == "0")
            {
                iLottery = Convert.ToString(rnd.Next(1, 100));
                txtLottery3.Text = iLottery;
            }

           /* if (txtLottery3.Text != txtLottery1.Text || txtLottery3.Text != txtLottery2.Text || txtLottery3.Text != txtLottery4.Text || txtLottery3.Text != txtLottery5.Text || 
                txtLottery3.Text != txtLottery6.Text)*/
            {
                iLottery = Convert.ToString(rnd.Next(1, 100));
                txtLottery1.Text = iLottery;
            }
            btnLottery.Enabled = true;

            txtLottery3.BackColor = Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255));
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            iLottery = Convert.ToString(rnd.Next(1, 100));
            txtLottery4.Text = iLottery;

            if (txtLottery4.Text == "0")
            {
                iLottery = Convert.ToString(rnd.Next(1, 100));
                txtLottery4.Text = iLottery;
            }

            if (txtLottery4.Text == txtLottery1.Text || txtLottery4.Text == txtLottery2.Text || txtLottery4.Text == txtLottery3.Text || txtLottery4.Text == txtLottery5.Text || txtLottery4.Text == txtLottery6.Text)
            {
                iLottery = Convert.ToString(rnd.Next(1, 100));
                txtLottery4.Text = iLottery;
            }
            btnLottery.Enabled = true;

            txtLottery4.BackColor = Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255));
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            iLottery = Convert.ToString(rnd.Next(1, 100));
            txtLottery5.Text = iLottery;

            if (txtLottery5.Text == "0")
            {
                iLottery = Convert.ToString(rnd.Next(1, 100));
                txtLottery5.Text = iLottery;
            }

            if (txtLottery5.Text == txtLottery1.Text || txtLottery5.Text == txtLottery2.Text || txtLottery5.Text == txtLottery3.Text || txtLottery5.Text == txtLottery4.Text || txtLottery5.Text == txtLottery6.Text)
            {
                iLottery = Convert.ToString(rnd.Next(1, 100));
                txtLottery5.Text = iLottery;
            }
            btnLottery.Enabled = true;

            txtLottery5.BackColor = Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255));
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            iLottery = Convert.ToString(rnd.Next(1, 100));
            txtLottery6.Text = iLottery;

            if (txtLottery6.Text == "0")
            {
                iLottery = Convert.ToString(rnd.Next(1, 100));
                txtLottery6.Text = iLottery;
            }

            if (txtLottery6.Text == txtLottery1.Text || txtLottery6.Text == txtLottery2.Text || txtLottery6.Text == txtLottery3.Text || txtLottery6.Text == txtLottery4.Text || txtLottery6.Text == txtLottery5.Text)
            {
                iLottery = Convert.ToString(rnd.Next(1, 100));
                txtLottery6.Text = iLottery;
            }
            btnLottery.Enabled = true;

            txtLottery6.BackColor = Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255));
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            iStore = iStore - 1;

            if (iStore == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
            }

        }

        private void txtLottery1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLottery2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLottery4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLottery6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLottery3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLottery1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtLottery5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
