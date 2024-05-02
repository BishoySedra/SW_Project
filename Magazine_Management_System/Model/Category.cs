using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_Management_System.Model
{
    internal class Category
    {
        public int Id;
        public string Name;
        public Category(string name)
        {
            Name = name;
        }
    }
}
