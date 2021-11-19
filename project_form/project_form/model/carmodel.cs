using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_form.model
{
    public class carmodel
    {
        public int id { get; set; }
        public string ten { get; set; }
        public string img { get; set; }
        public carmodel()
        {

        }
        public carmodel(int id,string ten,string img)
        {
            this.id = id;
            this.ten = ten;
            this.img = img;
        }
    }
}
