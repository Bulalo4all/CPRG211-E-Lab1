//Solution to question 1
namespace CPRG211Lab1;

public class Person
{
    //Attributes
    public int personId;
    public string firstName;
    public string lastName;
    public string favoriteColour;
    public int age;
    public bool isWorking;

    //Constructor
    public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
    {
        this.personId = personId;
        this.firstName = firstName;
        this.lastName = lastName;
        this.favoriteColour = favoriteColour;
        this.age = age;
        this.isWorking = isWorking;
    }
    
    public string DisplayPersonInfo()
    {
        string name = $"{this.firstName} {this.lastName}";
        return $"{this.personId}: {name}'s favorite color is {this.favoriteColour}";
    }

    public string ChangeFavoriteColor()
    {
        this.favoriteColour = "white";
        return favoriteColour; 
    }

    public int GetAgeInTenYears()
    {
        int ageInTenYears = this.age;
        ageInTenYears = ageInTenYears + 10;
        return ageInTenYears;
    }

    public override string ToString()
    {
        return $"ID: {this.personId} \n" +
            $"First Name: {this.firstName} \n" +
            $"Last Name: {this.lastName} \n" +
            $"Favorite Color: {this.favoriteColour} \n" +
            $"age: {this.age} \n" +
            $"Employed: {this.isWorking}";
    }


}
    