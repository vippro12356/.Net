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
using System.IO;
using project_form.model;
namespace project_form
{
    public partial class Homeform : Form
    {
        public Homeform()
        {
            InitializeComponent();
            loadtable();      
        }
        car c = new car();
        services sv = new services();       
        public Panel pannelproduct(string direct, string productname, string id)
        {
            Panel panel = new Panel();
            panel.Size = new Size(270, 270);
            PictureBox ptbox = new PictureBox();
            ptbox.Height = 200;
            ptbox.Width = 200;
            ptbox.Image = sv.getimg(direct,200,200);
            ptbox.Location = new Point(0, 0);
            Label lbid = new Label();
            lbid.Size = new Size(100, 22);
            lbid.ForeColor = Color.FromArgb(255, 255, 255);
            lbid.Font = new Font("Comic Sans MS", 12);
            lbid.Text = "ID:" + id;
            lbid.Location = new Point(0, 210);
            LinkLabel label = new LinkLabel();
            label.Size = new Size(150, 40);           
            label.Font = new Font("Comic Sans MS", 12);
            label.LinkColor = Color.FromArgb(255, 255, 255);
            label.AutoSize = true;
            label.Text = "Tên xe:" + productname;
            label.Location = new Point(0, 230);
            label.Click += new EventHandler((s, e) => detail(s, e, id));
            panel.Controls.Add(ptbox);
            panel.Controls.Add(lbid);
            panel.Controls.Add(label);
            return panel;
        }
        public void detail(object sender,EventArgs e,string id)
        {        
            Panel p=this.Parent as Panel;
            p.Controls.Clear();
            detail dt = new detail(id);
            dt.FormBorderStyle = FormBorderStyle.None;
            dt.TopLevel = false;
            p.Controls.Add(dt);
            dt.Show();
        }       
        public void loadtable()
        {
            DataTable dt = c.tablexe();
            foreach(DataRow row in dt.Rows)
            {
                string id = row.ItemArray[0].ToString();
                string ten = row.ItemArray[1].ToString();                
                string direct = sv.directory() + row.ItemArray[5].ToString();
                Panel pn = pannelproduct(direct, ten, id);
                flowLayoutPanel1.Controls.Add(pn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenxe = textBox1.Text;
            if(tenxe.Length>0)
            {
                List<carmodel> l = c.timkiem(tenxe);
                if(l.Count==0)
                {
                    MessageBox.Show("Không có mặt hàng này");
                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    foreach(carmodel car in l)
                    {
                        string id = car.id.ToString();
                        string ten = car.ten;
                        string direct = sv.directory() + car.img;
                        Panel pn = pannelproduct(direct, ten, id);
                        flowLayoutPanel1.Controls.Add(pn);
                    }                   
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
