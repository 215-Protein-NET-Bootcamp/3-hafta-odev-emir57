using AccountManager.Business.Abstract;
using AccountManager.Data.Abstract;
using AccountManager.Dto.Concrete;
using AccountManager.Entity.Concrete;
using AutoMapper;
using Core.DataAccess;
using Core.Utilities.Results;

namespace AccountManager.Business.Concrete
{
    public class AccountManager : AsyncBaseManager<AccountDto, Account>, IAccountService
    {
        public AccountManager(IAccountDal repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public override Task<IResult> AddAsync(AccountDto entity)
        {
            return base.AddAsync(entity);
        }

        public override Task<IResult> UpdateAsync(int id, AccountDto entity)
        {
            return base.UpdateAsync(id, entity);
        }
    }
}
