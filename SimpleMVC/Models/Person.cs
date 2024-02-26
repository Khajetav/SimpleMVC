namespace SimpleMVC.Models;

public class Person
{
    // ID gets detected in the word automatically
    // main key
    public int PersonId {get; set;}
    public string FirstName {get; set;} = null!;
    public string LastName {get; set;} = null!;
    
    public string MiddleName {get; set;}

}