using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace project_form.control
{
    public class login:DbCon
    {     
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();       
        public login()
        {
            loadacc();
        }
        public void loadacc()
        {
            string sql = "select * from account";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "account");
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["account"].Columns[0];
            ds.Tables["account"].PrimaryKey = key;
        }
        public void _login(string username,string password,Form f)
        {
            DataRow row = ds.Tables["account"].Rows.Find(username);
            if(row==null)
            {
                MessageBox.Show("sai tài khoản hoặc mật khẩu");
            }
            else
            {
                string pass = row.ItemArray[1].ToString();
                if(password.Trim().Equals(pass.Trim()))
                {
                    f.Visible = false;
                    string role = row.ItemArray[3].ToString();                  
                    if(role.Trim().Equals("admin"))
                    {                       
                        Admin ad = new Admin(username);
                        ad.Show();
                    }
                    else
                    {                        
                        Dashboard db = new Dashboard(username);
                        db.Show();                     
                    }
                }
                else
                {
                    MessageBox.Show("sai tài khoản hoặc mật khẩu");
                }
            }
        }
    }
}
