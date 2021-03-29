using System.Collections.Generic;
using AutoMapper;
using Auth_API.Data.Contract;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Linq;
using Models;
using edusite_api.Services.Contract;
using Dtos.User;
using Dtos.Role;

namespace Auth_API.Controllers
{
    [Authorize(Roles = "MasterAdmin")]
    [Route("V4/api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _repository;
        private readonly IRoleRepo _roleRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IAuthService _authService;

        public UsersController(IUserRepo repository, IRoleRepo roleRepository, UserManager<User> userManager, IMapper mapper, IAuthService authService)
        {
            _repository = repository;
            _userManager = userManager;
            _mapper = mapper;
            _roleRepository = roleRepository;
            _authService = authService;
        }

        //Get  api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserReadDto>>> GetAllUsers()
        {
            var Users = _repository.GetAll();
            //var mapedUsers = _mapper.Map<IEnumerable<UserReadDto>>(Users);
            var usersList = new List<UserReadDto>();
            foreach (var user in Users)
            {
                var rolesList = await _userManager.GetRolesAsync(user);
                foreach (var name in rolesList)
                {
                    var role = _roleRepository.GetRoleByName(name);
                    var UserReadDTO = _mapper.Map<UserReadDto>(user);
                    UserReadDTO.Role = _mapper.Map<RoleReadDto>(role);
                    UserReadDTO.RoleId = role.Id;
                    usersList.Add(UserReadDTO);
                }
            }
            return Ok(usersList);
        }

        //put  api/Users/5
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUser(Guid id, UserUpdateDto User)
        {
            var UserFromDB = _repository.GetUserById(id);
            if (UserFromDB == null)
            {
                return NotFound();
            }
            //_mapper.Map(User, UserFromDB);
            UserFromDB.UserName = User.UserName;
            UserFromDB.Email = User.Email;
            UserFromDB.IsActive = User.IsActive;
            UserFromDB.LanguageId = User.LanguageId;
            UserFromDB.FirstName = User.FirstName;
            UserFromDB.LastName = User.LastName;


            //TODO :Update Password
            var result = await _userManager.UpdateAsync(UserFromDB);
            if (!result.Succeeded)
            {
                var errors = string.Empty;

                foreach (var error in result.Errors)
                    errors += $"{error.Description},";

                return BadRequest(errors);
            }
            // _repository.UpdateUser(UserFromDB);
            //_repository.SaveChanges();

            return NoContent();
        }



        //Delete  api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUserAsync(Guid id)
        {
            var UserFromDB = _repository.GetUserById(id);
            if (UserFromDB == null)
            {
                return NotFound();
            }
            //TODO :handel when delete verify if user had and opration before
            var result = await _userManager.DeleteAsync(UserFromDB);
            //_repository.DeleteUser(UserFromDB);
            _repository.SaveChanges();

            return NoContent();
        }


        //Get  api/Users/5
        //[HttpGet("{id}", Name = "GetUserById")]
        //public ActionResult<UserReadDto> GetUserById(Guid id)
        //{
        //    var User = _repository.GetUserById(id);
        //    if (User != null)
        //    {

        //        return Ok(_mapper.Map<UserReadDto>(User));
        //    }
        //    return NotFound();
        //}

        //Post  api/Users
        //[HttpPost]
        //public ActionResult<UserCreateDto> CreateUser(UserCreateDto User)
        //{
        //    var UserModel = _mapper.Map<User>(User);
        //    _repository.CreateUser(UserModel);
        //    _repository.SaveChanges();

        //    var UserReadDto = _mapper.Map<UserReadDto>(UserModel);

        //    return CreatedAtRoute(nameof(GetUserById), new { id = UserReadDto.Id }, UserReadDto);
        //}

    }

}