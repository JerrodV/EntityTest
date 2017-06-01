using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using EntityTest.Helpers;

namespace EntityTest
{   
    class Program
    {
        static void Main(string[] args)
        {            
            using (TestPeopleEntities db = new TestPeopleEntities())
            {
                Console.WriteLine("Get People Results:");
                List<Person> people = db.GetPeople().ToType<List<Person>>();
                foreach (var p in people)
                {
                    Console.WriteLine(p.FirstName + " " + p.LastName);
                }
                Console.WriteLine("");

                Console.WriteLine("Bet By ID:");
                List<Person> p1 = db.GetPerson(3).ToType<List<Person>>();
                Console.WriteLine(p1[0].LastName + " " + p1[0].FirstName);
            }
            Console.ReadKey();
        }
    }
}
