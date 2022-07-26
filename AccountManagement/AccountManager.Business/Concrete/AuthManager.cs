using AccountManager.Business.Abstract;
using AccountManager.Dto.Concrete;
using Core.Entity.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly ITokenHelper _tokenHelper;
        private readonly IAccountService _accountService;

        public AuthManager(IAccountService accountService, ITokenHelper tokenHelper)
        {
            _accountService = accountService;
            _tokenHelper = tokenHelper;
        }

        public async Task<IDataResult<AccessToken>> CreateAccessTokenAsync(Account account)
        {
            return await Task.Run(() =>
            {
                return new SuccessDataResult<AccessToken>(_tokenHelper.CreateToken(account));
            });
        }

        public Task<IDataResult<Account>> LoginAsync(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> RegisterAsync(RegisterDto registerDto)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UserExistsAsync(string usernameOrEmial)
        {
            Account account = _accountService.get
        }
    }
}
