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
        public SqlConnection conn = new SqlConnection("Data Source = ADMIN; Initial Catalog = DB_CNNET_QLCHXEOTO; Integrated Security = True");
    }
}
