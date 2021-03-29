using System;
using System.Collections.Generic;
using System.Linq;
using edusite_api.Data;
using edusite_api.Data.Contract;
using Microsoft.EntityFrameworkCore;
using Models;

namespace edusite_api.Repository
{
    public class AccountRepo : IAccountRepo
    {
        private readonly DataContext _ctx;

        public AccountRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateAccount(Account s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            s.CreatedDate = DateTime.Now;
            _ctx.Accounts.Add(s);
        }

        public void DeleteAccount(Account s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Accounts.Remove(s);
        }

        public IEnumerable<Account> GetAll()
        {
            return _ctx.Accounts.ToList();
        }

        public Account GetAccountById(int id)
        {
            return _ctx.Accounts.FirstOrDefault(s => s.AccountId == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdateAccount(Account s)
        {
            //nothing
        }

        public Account GetAccountByUsernameAndPassword(string username, string password)
        {
            return _ctx.Accounts.Where(a => a.UserName == username && a.Password == password && a.IsActive == true).FirstOrDefault();
        }
    }
}