using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_form.control;
namespace project_form
{
    public partial class Nhanvien : Form
    {
        services sv = new services();
        public Nhanvien()
        {
            InitializeComponent();           
        }              
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            sv.mouseenter(button1);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            sv.mouseleave(button1);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            sv.mouseenter(button2);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            sv.mouseleave(button2);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            sv.mouseenter(button3);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            sv.mouseleave(button3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
