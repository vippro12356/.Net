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
    public partial class detail : Form
    {
        car c = new car();
        services sv = new services();
        public detail(string id)
        {
            InitializeComponent();
            loaddata(id);
        }       
        public void loaddata(string id)
        {
            DataRow row = c.findrow(id);           
            string direct = sv.directory() + row.ItemArray[5].ToString();
            pictureBox1.Image = sv.getimg(direct,pictureBox1.Width,pictureBox1.Height);
            label7.Text = row.ItemArray[0].ToString();
            label8.Text = row.ItemArray[1].ToString();
            label9.Text = row.ItemArray[7].ToString();
            label10.Text = row.ItemArray[8].ToString();
            label11.Text = row.ItemArray[4].ToString();
            label12.Text = row.ItemArray[3].ToString() + "$";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel p = this.Parent as Panel;
            p.Controls.Clear();
            Homeform home = new Homeform();
            home.FormBorderStyle = FormBorderStyle.None;
            home.TopLevel = false;
            p.Controls.Add(home);
            home.Show();
        }
    }
}
