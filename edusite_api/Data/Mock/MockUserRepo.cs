//using System.Collections.Generic;
//using Auth_API.Data.Contract;
//using Auth_API.Models;

//namespace Auth_API.Data.Mock
//{
//    public class MockUserRepo : IUserRepo
//    {
//        public void CreateUser(User s)
//        {
//            throw new System.NotImplementedException();
//        }

//        public void DeleteUser(User s)
//        {
//            throw new System.NotImplementedException();
//        }

//        public IEnumerable<User> GetAll()
//        {
//            var Users = new List<User>
//            {
//                 new User{Id=0 , name="Ahmed"},
//                 new User{Id=0 , name="Ahmed"},
//                 new User{Id=0 , name="Ahmed"}
//            };
//            return Users;
//        }

//        public User GetUserById(int id)
//        {
//            return new User { Id = 0, name = "Ahmed" };
//        }

//        public bool SaveChanges()
//        {
//            throw new System.NotImplementedException();
//        }

//        public void UpdateStudent(User s)
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}