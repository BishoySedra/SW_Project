using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_Management_System.Model
{
    internal class Subscription
    {
        public int Reader_Id;
        public int Magazine_Id;
        public OracleDate StartDate;
        public OracleDate EndDate;
    }
}
