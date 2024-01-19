using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Solution to Question 2
namespace CPRG211Lab1;

public class Relation
{

    //Attributes
    public string relationshipType;
        
    //Constructor
    public Relation(Person person1, Person person2, string relationshipType)
    {
        this.relationshipType = relationshipType;
    }
    public string showRelationship(Person person1, Person person2)
    {
        return $"Relationship between {person1.firstName} and {person2.firstName} is: {this.relationshipType}hood"; 
    }

}

