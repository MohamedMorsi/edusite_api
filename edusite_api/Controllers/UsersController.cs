using System.Collections.Generic;
using AutoMapper;
using Auth_API.Data.Contract;
//using Auth_API.Data.Mock;
using Auth_API.Dtos.User;
using Auth_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Auth_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _repository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //Get  api/Users
        [HttpGet]
        public ActionResult<IEnumerable<UserReadDto>> GetAllUsers()
        {
            var Users = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(Users));
        }

        //Get  api/Users/5
        [HttpGet("{id}", Name = "GetUserById")]
        public ActionResult<UserReadDto> GetUserById(Guid id)
        {
            var User = _repository.GetUserById(id);
            if (User != null)
            {

                return Ok(_mapper.Map<UserReadDto>(User));
            }
            return NotFound();
        }

        //Post  api/Users
        [HttpPost]
        public ActionResult<UserCreateDto> CreateUser(UserCreateDto User)
        {
            var UserModel = _mapper.Map<User>(User);
            _repository.CreateUser(UserModel);
            _repository.SaveChanges();

            var UserReadDto = _mapper.Map<UserReadDto>(UserModel);

            return CreatedAtRoute(nameof(GetUserById), new { id = UserReadDto.UserId }, UserReadDto);
        }

        //put  api/Users/5
        [HttpPut("{id}")]
        public ActionResult UpdateUser(Guid id, UserUpdateDto User)
        {
            var UserFromDB = _repository.GetUserById(id);
            if (UserFromDB == null)
            {
                return NotFound();
            }
            _mapper.Map(User, UserFromDB);
            _repository.UpdateUser(UserFromDB);
            _repository.SaveChanges();

            return NoContent();
        }

        //Delete  api/Users/5
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(Guid id)
        {
            var UserFromDB = _repository.GetUserById(id);
            if (UserFromDB == null)
            {
                return NotFound();
            }

            _repository.DeleteUser(UserFromDB);
            _repository.SaveChanges();

            return NoContent();
        }
    }

}