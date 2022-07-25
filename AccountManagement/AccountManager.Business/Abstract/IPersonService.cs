using AccountManager.Dto.Concrete;
using AccountManager.Entity.Concrete;

namespace AccountManager.Business.Abstract
{
    public interface IPersonService : IAsyncBaseService<PersonDto, Person>
    {
    }
}
