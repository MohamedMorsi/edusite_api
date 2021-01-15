using System;
using System.Collections.Generic;
using System.Linq;
using Auth_API.Data.Contract;
using Auth_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth_API.Data.Repository
{
    public class CurrentActiveUserRepo : ICurrentActiveUserRepo
    {
        private readonly DataContext _ctx;

        public CurrentActiveUserRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateCurrentActiveUser(CurrentActiveUser s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            s.CreatedDate = DateTime.Now;
            s.ExpiryDate = s.CreatedDate.AddHours(1);
            _ctx.CurrentActiveUsers.Add(s);
        }

        public void DeleteCurrentActiveUser(CurrentActiveUser s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.CurrentActiveUsers.Remove(s);
        }

        public IEnumerable<CurrentActiveUser> GetAll()
        {
            return _ctx.CurrentActiveUsers.ToList();
        }

        public CurrentActiveUser GetCurrentActiveUserById(Guid id)
        {
            return _ctx.CurrentActiveUsers.FirstOrDefault(s => s.CurrentActiveUserId == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdateCurrentActiveUser(CurrentActiveUser s)
        {
            //nothing
        }

    }
}