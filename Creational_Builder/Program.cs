using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Builder
{
    internal class Program
    {
        // Fluent Builder Inheritance with Generics
        //public static void Main(string[] args)
        //{
        //    var person = Person.New.Called("Dmitri").WorksAsA("Developer").Build();
        //    Console.WriteLine(person.Name + " " + person.Position);
        //}


        // Functional Builder
        //public static void Main(string[] args)
        //{
        //    var person = new PersonBuilder().Called("Dimitri").WorksAsA("Developer").Build;
        //}

        //Faceted Builder
        public static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb.Works.At("Somewhere").AsA("Software Engineer")
                            .Lives.At("Some Stress").In("Singapore").WithPostalCode("123456");

            Console.WriteLine(person);
        }
    }

}
