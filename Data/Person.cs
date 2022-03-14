namespace HelloWord.Data;
using System.Numerics;

/*

<form action="person">
    Name: <input name="name" /><br>
    Surname: <input name="surname" /><br>
    PESEL: <input name="pesel" /><br>
    Email: <input name="email" /><br>
    Telephone: <input name="phone" />
*/

public class Person
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Pesel { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
}