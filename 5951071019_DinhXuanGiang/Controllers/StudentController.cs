using _5951071019_DinhXuanGiang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5951071019_DinhXuanGiang.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {

            var studentInfList = new List<StudentInfo>();
            for (int i = 0; i < 10; i++)
            {

                var StudentInfo = new StudentInfo
                {

                    Name = $"Dinh Xuan Giang",
                    ID = 5951071019,
                    Age = 21

                };
                studentInfList.Add(StudentInfo);
            }
            return studentInfList;
        }
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                Name = $"Nguyen Anh Tuan",
                ID = 5951071117,
                Age = 21
            };
        }
        // GET: api/Student/5


        // POST: api/Student
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
