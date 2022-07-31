using AccountManager.Dto.Concrete;
using AccountManager.Entity.Concrete;
using Core.Utilities.Results;

namespace AccountManager.Business.Abstract
{
    public interface IPersonService : IAsyncBaseService<PersonDto, Person>
    {
        Task<DataResult<List<Person>>> GetPersonsAsync();
    }
}
