using AccountManager.Business.Abstract;
using AccountManager.Data.Abstract;
using AccountManager.Dto.Concrete;
using AccountManager.Entity.Concrete;
using AutoMapper;
using Core.Extensions.Jwt;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;

namespace AccountManager.Business.Concrete
{
    public class PersonManager : AsyncBaseManager<PersonDto, Person>, IPersonService
    {
        private readonly IPersonDal _personDal;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public PersonManager(IPersonDal repository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repository, mapper)
        {
            _personDal = repository;
            _httpContextAccessor = httpContextAccessor;
        }

        public override Task<IResult> AddAsync(PersonDto entity)
        {
            return base.AddAsync(entity);
        }

        public async Task<IDataResult<List<Person>>> GetPersons()
        {
            string loginedAccountId = _httpContextAccessor.HttpContext.User.ClaimId();
            var persons = await _personDal.GetAllAsync(x => x.AccountId == int.Parse(loginedAccountId));
            return new SuccessDataResult<List<Person>>(persons.ToList());
        }

        public override Task<IResult> UpdateAsync(int id, PersonDto entity)
        {
            return base.UpdateAsync(id, entity);
        }
    }
}
