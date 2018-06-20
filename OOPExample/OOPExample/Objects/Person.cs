using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample.Objects
{
    public class Person
    {
        public string _Name { get; set; }
        public string _Gender { get; set; }
        public int _Age { get; set; }
        public double _Height { get; set; }
        public DateTime _DOB { get; set; }

        public Person()
        {

        }

        public Person(string[] iProperties)
        {
            _Name = iProperties[0];
            _Gender = iProperties[1];
            _Age = Convert.ToInt32(iProperties[2]);
            _Height = Convert.ToDouble(iProperties[3]);
            _DOB = Convert.ToDateTime(iProperties[4]);
        }
    }
}
