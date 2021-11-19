using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace project_form.control
{
    public class services
    {       
        
        public Image getimg(string direct,int w,int h)
        {
            Image i = Image.FromFile(direct);
            return (Image)(new Bitmap(i, new Size(w, h)));
        }
        public string directory()
        {
            string curdirect = Environment.CurrentDirectory;
            string direct = curdirect.Substring(0, curdirect.Length - 9) + "imgcar/";
            return direct;
        }
        public void mouseenter(Button button)
        {
            button.BackColor = Color.FromArgb(189, 191, 190);
        }
        public void mouseleave(Button button)
        {
            button.BackColor = Color.FromArgb(0, 0, 0);
        }
        public bool checkphonenumber(string s)
        {
            if(s.All(char.IsNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkemail(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false; 
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
