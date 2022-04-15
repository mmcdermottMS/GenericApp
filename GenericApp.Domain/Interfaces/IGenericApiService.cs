using GenericApp.Domain.Models;

namespace GenericApp.Domain.Interfaces
{
    public interface IGenericApiService
    {
        public Task<Person?> GetPerson();
    }
}
