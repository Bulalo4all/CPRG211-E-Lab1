using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211Lab1;
class Program
{
    static void Main()
    {
        //Solution to Question 3a)
        Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
        Person gina = new Person(2, "Gina", "James", "Green", 18, false);
        Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
        Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

        //Solution to Question 3b)
        Console.WriteLine(gina.DisplayPersonInfo());

        //Solution to question 3c)
        Console.WriteLine(mike.ToString());

        //Solution to 3d)
        ian.ChangeFavoriteColor();
        Console.WriteLine(ian.DisplayPersonInfo());

        //Solution to 3e)
        Console.WriteLine($"Mary Beal's Age in 10 years is: {mary.GetAgeInTenYears()}");

        //Solution to 3f)
        Relation ginaToMary = new Relation(gina, mary, "Sister");
        Relation ianToMike = new Relation(ian, mike, "Brother");

        Console.WriteLine(ginaToMary.showRelationship(gina, mary));
        Console.WriteLine(ianToMike.showRelationship(ian, mike));

        //Solution to 3g
        List<Person> list = new List<Person>();

        list.Add(ian);
        list.Add(gina);
        list.Add(mike);
        list.Add(mary);

        //Uses the list function Average to find average age
        Console.WriteLine($"The Average age is: {list.Average(x => x.age)}");

        //Uses list function find to find the youngest person in the list by also using the list function min
        Console.WriteLine($"The Youngest person is: {list.Find(x => x.age == list.Min(x => x.age)).firstName}");
        
        //Uses list function find to find the oldest person by also using the list function max
        Console.WriteLine($"THe Oldest person is: {list.Find(x => x.age == list.Max(x => x.age)).firstName}");

        //Uses list function find to find the person who's favorite color is blue
        Console.WriteLine(list.Find(x => x.favoriteColour == "Blue"));
        

        

    }
}
