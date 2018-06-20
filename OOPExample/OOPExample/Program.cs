using OOPExample.Objects;
using OOPExample.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    public class Program
    {

        public static Person _Person { get; set; }
        public static Functions _Functions { get; set; }

        public Program()
        {
            _Person = new Person();
            _Functions = new Functions();
            _Functions = new Functions(_Person);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a person's peroperties (comma delimited)");
            string properties = Console.ReadLine();
            string[] propertiesArray = properties.Split(',');

            Person lPerson = new Person();
            lPerson = FillPersonObject(propertiesArray);
            Console.WriteLine(lPerson);

            DoDependencyInjection(propertiesArray);
            Console.WriteLine(_Person);

            Functions._Person = Functions.FillPersonObject(propertiesArray);
            Console.WriteLine(Functions._Person);

            Functions.DoDependencyInjection(propertiesArray);
            Console.WriteLine(Functions._Person);
            
            Console.ReadKey();
        }

        private static void DoDependencyInjection(string[] iProperties)
        {
            _Person = new Person(iProperties);   
        }

        private static Person FillPersonObject(string[] iProperties)
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
