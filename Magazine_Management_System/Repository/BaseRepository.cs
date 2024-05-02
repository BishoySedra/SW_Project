using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Magazine_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Magazine_Management_System.Repository
{
    internal abstract class BaseRepository
    {
        protected string ordb = "Data source=orcl;User Id=hr;   Password = hr; ";

        protected OracleConnection conn;

        protected BaseRepository() 
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        ~BaseRepository()
        {
            conn.Dispose();
        }
    }
}
