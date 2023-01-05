using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRef
{
    public class Person
    {
        [DisplayAtributeProperties("First Name")]
        public string FirstName { get; set; }
        [DisplayAtributeProperties("Last Name")]
        public string LastName { get; set; }
        public Adress Adress { get; set; }
    }
}
