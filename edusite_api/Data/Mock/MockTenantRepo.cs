//using System.Collections.Generic;
//using Auth_API.Data.Contract;
//using Auth_API.Models;

//namespace Auth_API.Data.Mock
//{
//    public class MockTenantRepo : ITenantRepo
//    {
//        public void CreateTenant(Tenant s)
//        {
//            throw new System.NotImplementedException();
//        }

//        public void DeleteTenant(Tenant s)
//        {
//            throw new System.NotImplementedException();
//        }

//        public IEnumerable<Tenant> GetAll()
//        {
//            var Tenants = new List<Tenant>
//            {
//                 new Tenant{Id=0 , name="Ahmed"},
//                 new Tenant{Id=0 , name="Ahmed"},
//                 new Tenant{Id=0 , name="Ahmed"}
//            };
//            return Tenants;
//        }

//        public Tenant GetTenantById(int id)
//        {
//            return new Tenant { Id = 0, name = "Ahmed" };
//        }

//        public bool SaveChanges()
//        {
//            throw new System.NotImplementedException();
//        }

//        public void UpdateTenant(Tenant s)
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}