using AccountManager.Data.Abstract;
using AccountManager.Dto.Concrete;
using AccountManager.Entity.Concrete;
using AutoMapper;
using Core.Utilities.Results;

namespace AccountManager.Business.Concrete
{
    public class PersonManager : AsyncBaseManager<PersonDto, Person>
    {
        public PersonManager(IPersonDal repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public override Task<IResult> AddAsync(PersonDto entity)
        {
            return base.AddAsync(entity);
        }

        public override Task<IResult> UpdateAsync(int id, PersonDto entity)
        {
            return base.UpdateAsync(id, entity);
        }
    }
}
