using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace project_form
{
    public partial class Admin : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Admin(string val)
        {
            InitializeComponent();
            label1.Text = "Xin chào:"+val;
            this.panel3.Controls.Clear();
            Account acc = new Account()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            acc.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(acc);
            acc.Show();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            Form1 login = new Form1();
            login.Show();
        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            Account acc = new Account()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            acc.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(acc);
            acc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel3.Controls.Clear();
            Nhanvien mng = new Nhanvien()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            mng.FormBorderStyle = FormBorderStyle.None;
            this.panel3.Controls.Add(mng);
            mng.Show();
        }

        private void buttonhome_MouseEnter(object sender, EventArgs e)
        {
            buttonaccount.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttonhome_MouseLeave(object sender, EventArgs e)
        {
            buttonaccount.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void buttonmanage_MouseEnter(object sender, EventArgs e)
        {
            buttonmanage.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttonmanage_MouseLeave(object sender, EventArgs e)
        {
            buttonmanage.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void buttonlogout_MouseEnter(object sender, EventArgs e)
        {
            buttonlogout.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttonlogout_MouseLeave(object sender, EventArgs e)
        {
            buttonlogout.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void buttonexit_MouseEnter(object sender, EventArgs e)
        {
            buttonexit.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttonexit_MouseLeave(object sender, EventArgs e)
        {
            buttonexit.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
