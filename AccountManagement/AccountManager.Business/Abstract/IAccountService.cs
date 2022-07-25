using AccountManager.Dto.Concrete;
using AccountManager.Entity.Concrete;

namespace AccountManager.Business.Abstract
{
    public interface IAccountService : IAsyncBaseService<AccountDto, Account>
    {
    }
}
