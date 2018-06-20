using OOPExample.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample.Worker
{
    public class Functions
    {
        public static Person _Person { get; set; }

        public Functions()
        {
            _Person = new Person();
        }

        public Functions(Person iPerson)
        {
            _Person = iPerson;
        }

        public static void DoDependencyInjection(string[] iProperties)
        {
            _Person = new Person(iProperties);
        }

        public static Person FillPersonObject(string[] iProperties)
        {
            Person lPerson = new Person();

            lPerson._Name = iProperties[0];
            lPerson._Gender = iProperties[1];
            lPerson._Age = Convert.ToInt32(iProperties[2]);
            lPerson._Height = Convert.ToDouble(iProperties[3]);
            lPerson._DOB = Convert.ToDateTime(iProperties[4]);

            return lPerson;
        }
    }
}
