using System.Collections.Generic;
using System.Linq;
using OefeningPersonsMvc.Entities;

namespace OefeningPersonsMvc.Services;

public interface IPersonData
{
    IEnumerable<Person> GetAll();
    Person Get(int id);
    Person Add(Person newPerson);
}


public class InMemoryPersonData : IPersonData
{
    static List<Person> persons;

    static InMemoryPersonData()
    {
        persons = new List<Person>
        {
            new Person {Id = 1, FirstName = "Jan", LastName = "Janssens", Gender = Gender.Male},
            new Person {Id = 2, FirstName = "Piet", LastName = "Pieters", Gender = Gender.Male}
        };
    }

    public IEnumerable<Person> GetAll()
    {
        return persons;
    }

    public Person Get(int id)
    {
        return persons.FirstOrDefault(x => x.Id == id);
    }

    public Person Add(Person newPerson)
    {
        newPerson.Id = persons.Max(x => x.Id) + 1;
        persons.Add(newPerson);

        return newPerson;
    }
}
