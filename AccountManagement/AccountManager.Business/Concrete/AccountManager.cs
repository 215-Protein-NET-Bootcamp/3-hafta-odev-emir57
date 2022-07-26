using AccountManager.Business.Abstract;
using AccountManager.Business.Constants;
using AccountManager.Data.Abstract;
using AccountManager.Dto.Concrete;
using AutoMapper;
using Core.Entity.Concrete;
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

        public async Task<IDataResult<Account>> GetAccountByEmailOrUsername(string emailOrUsername)
        {
            var account = await Repository.GetAsync(a => a.UserName.ToLower() == emailOrUsername.ToLower() || a.Email.ToLower() == emailOrUsername.ToLower());
            if (account == null)
                return new ErrorDataResult<Account>(BusinessMessages.NotFound);
            return new SuccessDataResult<Account>(account);
        }

        public override Task<IResult> UpdateAsync(int id, AccountDto entity)
        {
            return base.UpdateAsync(id, entity);
        }
    }
}
