using Models;
using System;
using System.Collections.Generic;

namespace edusite_api.Data.Contract
{
    public interface IAccountRepo
    {
        bool SaveChanges();
        IEnumerable<Account> GetAll();
        Account GetAccountById(int id);
        void CreateAccount(Account s);
        void UpdateAccount(Account s);
        void DeleteAccount(Account s);
        Account GetAccountByUsernameAndPassword(string username, string password);

    }
}