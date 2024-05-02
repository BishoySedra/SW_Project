using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Types;
namespace Magazine_Management_System.Model
{
    internal class Magazine
    {
        public int Id;
        public string Name;
        public int Admin_Id;
        public OracleDate PublicationDate;

        //make constructor
        public Magazine(string name, int admin_id, OracleDate publicationDate)
        {
            Name = name;
            Admin_Id = admin_id;
            PublicationDate = publicationDate;
        }
        public Magazine() { }

    }
}
