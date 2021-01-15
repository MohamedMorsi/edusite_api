//using System.Collections.Generic;
//using Auth_API.Data.Contract;
//using Auth_API.Models;

//namespace Auth_API.Data.Mock
//{
//    public class MockUserRepo : IUserRepo
//    {
//        public void CreateStudent(Student s)
//        {
//            throw new System.NotImplementedException();
//        }

//        public void DeleteStudent(Student s)
//        {
//            throw new System.NotImplementedException();
//        }

//        public IEnumerable<Student> GetAll()
//        {
//            var Students  = new List<Student>
//            {
//                 new Student{Id=0 , name="Ahmed"},
//                 new Student{Id=0 , name="Ahmed"},
//                 new Student{Id=0 , name="Ahmed"}
//            };
//            return Students;
//        }

//        public Student GetStudentById(int id)
//        {
//            return new Student{Id=0 , name="Ahmed"};
//        }

//        public bool SaveChanges()
//        {
//            throw new System.NotImplementedException();
//        }

//        public void UpdateStudent(Student s)
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}