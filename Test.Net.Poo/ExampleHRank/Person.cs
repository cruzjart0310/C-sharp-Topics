using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.Poo.ExampleHRank
{
    public class Person
    {
        public int age;

        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge

            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
                this.age = 0;
            }
            else
            {
                this.age = initialAge;
            }
        }

        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console   
            if (this.age < 13)
            {
                Console.WriteLine("You are young");
            }
            else if (this.age >= 13 && this.age < 18)
            {
                Console.WriteLine("You are teenager");
            }
            else
            {
                Console.WriteLine("You are old");
            }
        }

        public void yearPasses()
        {
            // Increment the age of the person in 
            this.age = this.age + 1;
        }
    }
}
