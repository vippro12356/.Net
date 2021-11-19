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
using project_form.control;
namespace project_form
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        login log = new login();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username.Length>0&&password.Length>0)
            {
                log._login(username, password, this);
            }
            else
            {
                MessageBox.Show("vui lòng nhập tên tài khoản và mật khẩu");
            }

        }
        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonexit_MouseEnter(object sender, EventArgs e)
        {
            buttonexit.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttonexit_MouseLeave(object sender, EventArgs e)
        {
            buttonexit.BackColor = Color.FromArgb(0, 0, 0);
        }
    }
}
