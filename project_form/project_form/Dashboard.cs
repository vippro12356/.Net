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
    public partial class Dashboard : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Dashboard(string val)
        {
            InitializeComponent();
            this.panelloadform.Controls.Clear();
            label1.Text = "Xin chào:"+val;
            Homeform homefrm = new Homeform()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            homefrm.FormBorderStyle = FormBorderStyle.None;
            this.panelloadform.Controls.Add(homefrm);
            homefrm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
            buttonhome.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button2carlist_MouseEnter(object sender, EventArgs e)
        {
           
            buttoncarlist.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttoncus_MouseEnter(object sender, EventArgs e)
        {
           
            buttoncus.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttonorder_MouseEnter(object sender, EventArgs e)
        {
            
            buttonorder.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttonlogout_MouseEnter(object sender, EventArgs e)
        {
           
            buttonlogout.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttonhome_MouseLeave(object sender, EventArgs e)
        {
            buttonhome.BackColor = Color.FromArgb(2, 20, 51);
        }

        private void buttoncarlist_MouseLeave(object sender, EventArgs e)
        {
            buttoncarlist.BackColor = Color.FromArgb(2, 20, 51);
        }

        private void buttoncus_MouseLeave(object sender, EventArgs e)
        {
            buttoncus.BackColor = Color.FromArgb(2, 20, 51);
        }

        private void buttonorder_MouseLeave(object sender, EventArgs e)
        {
            buttonorder.BackColor = Color.FromArgb(2, 20, 51);
        }

        private void buttonlogout_MouseLeave(object sender, EventArgs e)
        {
            buttonlogout.BackColor = Color.FromArgb(2, 20, 51);
        }

        private void buttonexit_MouseEnter(object sender, EventArgs e)
        {
            buttonexit.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttonexit_MouseLeave(object sender, EventArgs e)
        {
            buttonexit.BackColor = Color.FromArgb(2, 20, 51);
        }

        private void buttonstatic_MouseEnter(object sender, EventArgs e)
        {
            buttonstatic.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void buttonstatic_MouseLeave(object sender, EventArgs e)
        {
            buttonstatic.BackColor = Color.FromArgb(2, 20, 51);
        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            this.panelloadform.Controls.Clear();
            Homeform homefrm = new Homeform()
            {
                Dock=DockStyle.Fill,TopLevel=false,TopMost=true
            };
            homefrm.FormBorderStyle = FormBorderStyle.None;
            this.panelloadform.Controls.Add(homefrm);
            homefrm.Show();
        }

        private void buttoncarlist_Click(object sender, EventArgs e)
        {
            this.panelloadform.Controls.Clear();
            Carlist carlst = new Carlist()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            carlst.FormBorderStyle = FormBorderStyle.None;
            this.panelloadform.Controls.Add(carlst);
            carlst.Show();
        }

        private void buttoncus_Click(object sender, EventArgs e)
        {
            this.panelloadform.Controls.Clear();
            Customer cus = new Customer()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            cus.FormBorderStyle = FormBorderStyle.None;
            this.panelloadform.Controls.Add(cus);
            cus.Show();
        }
        public void addform(Form f)
        {
            f = new Form()
            {
                Dock=DockStyle.Fill,
                TopLevel=false,
                TopMost=true
            };
            f.FormBorderStyle = FormBorderStyle.None;
            this.panelloadform.Controls.Add(f);
            f.Show();
        }
        private void buttonorder_Click(object sender, EventArgs e)
        {
            this.panelloadform.Controls.Clear();
            Order ord = new Order()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            ord.FormBorderStyle = FormBorderStyle.None;
            this.panelloadform.Controls.Add(ord);
            ord.Show();
        }

        private void buttonstatic_Click(object sender, EventArgs e)
        {
            this.panelloadform.Controls.Clear();
            Statistic st = new Statistic()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            st.FormBorderStyle = FormBorderStyle.None;
            this.panelloadform.Controls.Add(st);
            st.Show();
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
            Form1 login = new Form1();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(0, 0, 0);
        }
    }
}
