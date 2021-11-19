using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace project_form.control
{
    public class DbCon
    {
        // public SqlConnection conn = new SqlConnection("Data Source = ADMIN; Initial Catalog = DB_CNNET_QLCHXEOTO; Integrated Security = True");
        public SqlConnection conn = new SqlConnection("Data Source=LAPTOP-0TF3JF7G\\DANGTRI;Initial Catalog=DB_CNNET_QLCHXEOTO;User ID=sa;Password=123");
    }
}
