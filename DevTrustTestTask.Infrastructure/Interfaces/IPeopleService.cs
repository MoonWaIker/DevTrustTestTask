using DevTrustTestTask.DataBase.Entities;
using DevTrustTestTask.Infrastructure.DTO;

namespace DevTrustTestTask.Infrastructure.Interfaces;

public interface IPeopleService
{
    void AddPerson(Person person);

    void UpdatePerson(Person person);

    IEnumerable<Person> GetPeople(GetAllRequest request);
}
