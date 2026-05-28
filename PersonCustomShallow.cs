using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class PersonCustomShallow
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public PersonCustomShallow ShallowClone()
        {
            return (PersonCustomShallow)this.MemberwiseClone();
        }
    }
}
