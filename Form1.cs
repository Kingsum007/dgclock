using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class frmclock : Form
    {
        Browser webb = new Browser();
        public frmclock()
        {
            InitializeComponent();
        }

        private void tmrcount_Tick(object sender, EventArgs e)
        {
            lblhour.Text = DateTime.Now.ToString("h:mm tt");
            lblsecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("dd MMMM yy");
            label1.Text = DateTime.Now.ToString("dddd");
            lblsecond.Location = new Point(lblhour.Location.X + lblhour.Width - 5, lblsecond.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrcount.Start();
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Opacity = 100;
            BackColor = Color.Aqua;
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
        }
        private void btnclose_MouseHover(object sender, EventArgs e)
        {
            btnclose.BackColor = Color.Green;
            btnclose.ForeColor = Color.White;
        }

        private void btnclose_MouseLeave(object sender, EventArgs e)
        {
            btnclose.BackColor = Color.Black;
            btnclose.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            Browser web = new Browser();
            web.Show();
        }
    }
}