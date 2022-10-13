using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.Poo.Accesors.Virtual
{
    public class Customer
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        // FullName is virtual
        public virtual string FullName
        {
            get
            {
                return _lastName + ", " + _firstName;
            }
        }
    }
}
