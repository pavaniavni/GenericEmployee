using System;

namespace Generic
{
    internal class Program
    {
        public class sample<P>
        {
            //field
            private P data;

            //property
            public P value
            {
                //accessors
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }

            }

        }
        public class Employee
        {
            public int EmpID { get; set; }
            public string EmpName { get; set; }
            public int EmpAge { get; set; }
            public double salary { get; set; }
            public string Address { get; set; }
        }
        static void Main(string[] args)
        {

            sample<string> name = new sample<string>();
            name.value = "Pavani";

            sample<float> version = new sample<float>();
            version.value = 6.0F;

            sample<int> count = new sample<int>();
            count.value = 4;
            //display Name
            Console.WriteLine(name.value);
            //display version
            Console.WriteLine(version.value);
            //display count
            Console.WriteLine(count.value);

            Employee E = new Employee()
            {
                EmpID = 84,
                EmpName = "Pavani",
                EmpAge = 21,
                salary = 500000f,
                Address = "Hyderabad "
            };
            Console.WriteLine("Employee Information");
            Console.WriteLine(E.EmpID);
            Console.WriteLine(E.EmpName);
            Console.WriteLine(E.EmpAge);
            Console.WriteLine(E.salary);
            Console.WriteLine(E.Address);
        }
    }
}

