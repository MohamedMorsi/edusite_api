using System;
using System.Collections.Generic;
using System.Linq;
using Auth_API.Data.Contract;
using Auth_API.Models;

namespace Auth_API.Data.Repository
{
    public class TenantRepo : ITenantRepo
    {
        private readonly DataContext _ctx;

        public TenantRepo(DataContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateTenant(Tenant s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            s.CreatedDate = DateTime.Now;
            _ctx.Tenants.Add(s);
        }

        public void DeleteTenant(Tenant s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }
            _ctx.Tenants.Remove(s);
        }

        public IEnumerable<Tenant> GetAll()
        {
            return _ctx.Tenants.ToList();
        }

        public Tenant GetTenantById(Guid id)
        {
            return _ctx.Tenants.FirstOrDefault(s => s.TenantId == id);
        }

        public bool SaveChanges()
        {
            return (_ctx.SaveChanges() >= 0);
        }

        public void UpdateTenant(Tenant s)
        {
            //nothing
        }
    }
}