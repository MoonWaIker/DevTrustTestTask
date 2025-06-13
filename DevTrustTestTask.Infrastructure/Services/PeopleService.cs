using DevTrustTestTask.DataBase.Contexts;
using DevTrustTestTask.DataBase.Entities;
using DevTrustTestTask.Infrastructure.DTO;
using DevTrustTestTask.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DevTrustTestTask.Infrastructure.Services;

public sealed class PeopleService(DevTrustTestTaskContext context) : IPeopleService
{
    private readonly DevTrustTestTaskContext _context = context;

    public void AddPerson(Person person)
    {
        _context.People.Add(person);

        _context.SaveChanges();
    }

    public IEnumerable<Person> GetPeople(GetAllRequest request)
    {
        return _context.People
            .Include(p => p.Address)
            .Where(p => (string.IsNullOrWhiteSpace(request.FirstName) || p.FirstName.Contains(request.FirstName, StringComparison.OrdinalIgnoreCase))
            && (string.IsNullOrWhiteSpace(request.LastName) || p.LastName.Contains(request.LastName, StringComparison.OrdinalIgnoreCase))
            && (string.IsNullOrWhiteSpace(request.City) || p.Address != null && p.Address.City.Contains(request.City, StringComparison.OrdinalIgnoreCase)));
    }

    public void UpdatePerson(Person person)
    {
        _context.People.Update(person);

        _context.SaveChanges();
    }
}
