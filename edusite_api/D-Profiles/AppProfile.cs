using AutoMapper;
using Dtos.Account;
using Models;

namespace edusite_api.Profiles
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            // createMap< source , destination >();
            CreateMap<Account, AccountReadDto>();
            CreateMap<AccountCreateDto, Account>();
            CreateMap<AccountUpdateDto, Account>();
        }
    }


}