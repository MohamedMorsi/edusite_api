using System;
using System.Collections.Generic;
using System.Linq;
using Auth_API.Data.Contract;
using Auth_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth_API.Data.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly DataContext _ctx;

        public UserRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateUser(User s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            s.CreatedDate = DateTime.Now;
            _ctx.Users.Add(s);
        }

        public void DeleteUser(User s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Users.Remove(s);
        }

        public IEnumerable<User> GetAll()
        {
            return _ctx.Users.Include(a => a.Tenant).ToList();
        }

        public User GetUserById(Guid id)
        {
            return _ctx.Users.Include(a => a.Tenant).FirstOrDefault(s => s.UserId == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdateUser(User s)
        {
            //nothing
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            return _ctx.Users.Where(a => a.UserName == username && a.Password == password && a.IsActive == true)
                .Include(a => a.Tenant).Include(a => a.Departments).FirstOrDefault();
        }
    }
}