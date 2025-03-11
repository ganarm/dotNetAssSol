using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class ClassA
    {
        private String name { set; get; }
        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }
    }
}
