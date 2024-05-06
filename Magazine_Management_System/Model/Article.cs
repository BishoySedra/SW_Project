using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_Management_System.Model
{
    internal class Article
    {
        public int Id;
        public string Title;
        public int Magazine_Id;
        public int Author_Id;
        public int Category_Id;
        public string Content;
        public string Status;
    }
}
