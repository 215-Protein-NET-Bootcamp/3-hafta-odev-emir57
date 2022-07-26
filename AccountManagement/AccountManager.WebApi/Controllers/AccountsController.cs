﻿using AccountManager.Business.Abstract;
using AccountManager.Dto.Concrete;
using AccountManager.Entity.Concrete;
using AutoMapper;
using Core.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AccountManager.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : BaseController<AccountDto, Account>
    {
        public AccountsController(IAccountService baseService, IMapper mapper) : base(baseService, mapper)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return await base.GetListAsync();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] int id)
        {
            return await base.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] AccountDto personDto)
        {
            return await base.AddAsync(personDto);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync([FromRoute] int id, [FromBody] AccountDto personDto)
        {
            return await base.UpdateAsync(id, personDto);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            return await base.DeleteAsync(id);
        }
    }
}