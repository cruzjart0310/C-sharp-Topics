using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.DataStructure.LinkedList
{
    public class ClNode
    {
        private int data { get; set; }

        private ClNode next = null;

        public int Data { get { return data; } set { data = value; } }
        internal ClNode Next { get { return next; } set { next = value; } }

        public override string ToString()
        {
            return String.Format("[{0}]", data);
        }
    }
}
