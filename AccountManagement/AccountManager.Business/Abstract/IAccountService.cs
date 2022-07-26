using AccountManager.Dto.Concrete;
using Core.Entity.Concrete;

namespace AccountManager.Business.Abstract
{
    public interface IAccountService : IAsyncBaseService<AccountDto, Account>
    {
    }
}
