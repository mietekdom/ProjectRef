using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRef
{
    public class DisplayAtributeProperties : Attribute
    {
        public string DisplayName { get; set; }

        public DisplayAtributeProperties(string displayName)
        {
            DisplayName = displayName;
        }
    }
}
