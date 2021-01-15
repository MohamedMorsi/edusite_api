using System;
using System.Collections.Generic;
using Auth_API.Models;

namespace Auth_API.Data.Contract
{
    public interface ICurrentActiveUserRepo
    {
        bool SaveChanges();
        IEnumerable<CurrentActiveUser> GetAll();
        CurrentActiveUser GetCurrentActiveUserById(Guid id);
        void CreateCurrentActiveUser(CurrentActiveUser s);
        void UpdateCurrentActiveUser(CurrentActiveUser s);
        void DeleteCurrentActiveUser(CurrentActiveUser s);

    }
}