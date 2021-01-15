using System;
using System.Collections.Generic;
using Auth_API.Models;

namespace Auth_API.Data.Contract
{
    public interface ITenantRepo
    {
        bool SaveChanges();
        IEnumerable<Tenant> GetAll();
        Tenant GetTenantById(Guid id);
        void CreateTenant(Tenant s);
        void UpdateTenant(Tenant s);
        void DeleteTenant(Tenant s);

    }
}