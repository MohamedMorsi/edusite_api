using System;
using System.Collections.Generic;
using Models;

namespace Auth_API.Data.Contract
{
    public interface IUserRepo
    {
        bool SaveChanges();
        IEnumerable<User> GetAll();
        User GetUserById(Guid id);
        void CreateUser(User s);
        void UpdateUser(User s);
        void DeleteUser(User s);
        User GetUserByUsernameAndPassword(string username, string password);

    }
}