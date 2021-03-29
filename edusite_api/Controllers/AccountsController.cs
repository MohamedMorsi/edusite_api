using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using Dtos.Account;
using edusite_api.Data.Contract;

namespace edusite_api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepo _repository;
        private readonly IMapper _mapper;

        public AccountsController(IAccountRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get  api/Accounts
        [HttpGet]
        public ActionResult<IEnumerable<AccountReadDto>> GetAllAccounts()
        {
            var Accounts = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<AccountReadDto>>(Accounts));
        }

        //Get  api/Accounts/5
        [HttpGet("{id}", Name = "GetAccountById")]
        public ActionResult<AccountReadDto> GetAccountById(int id)
        {
            var Account = _repository.GetAccountById(id);
            if (Account != null)
            {

                return Ok(_mapper.Map<AccountReadDto>(Account));
            }
            return NotFound();
        }

        //Post  api/Accounts
        [HttpPost]
        public ActionResult<AccountCreateDto> CreateAccount(AccountCreateDto Account)
        {
            var AccountModel = _mapper.Map<Models.Account>(Account);
            _repository.CreateAccount(AccountModel);
            _repository.SaveChanges();

            var AccountReadDto = _mapper.Map<AccountReadDto>(AccountModel);

            return CreatedAtRoute(nameof(GetAccountById), new { id = AccountReadDto.UserId }, AccountReadDto);
        }

        //put  api/Accounts/5
        [HttpPut("{id}")]
        public ActionResult UpdateAccount(int id, AccountUpdateDto Account)
        {
            var AccountFromDB = _repository.GetAccountById(id);
            if (AccountFromDB == null)
            {
                return NotFound();
            }
            _mapper.Map(Account, AccountFromDB);
            _repository.UpdateAccount(AccountFromDB);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete  api/Accounts/5
        [HttpDelete("{id}")]
        public ActionResult DeleteAccount(int id)
        {
            var AccountFromDB = _repository.GetAccountById(id);
            if (AccountFromDB == null)
            {
                return NotFound();
            }

            _repository.DeleteAccount(AccountFromDB);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}