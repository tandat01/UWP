using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E_HelloUWP.Models;

namespace T1809E_HelloUWP.Services
{
    class InmemoryStudentService: IStudentService
    {
        private static List<Student> _students = new List<Student>();
        public Task<Student> Create(Student student)
        {
            _students.Add(student);
            return Task.FromResult(student);
        }

        public Task<List<Student>> GetList()
        {
            //throw new NotImplementedException();
            return null;
        }

        public Task<Student> GetDetail(string rollNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Student> Update(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string rollNumber)
        {
            throw new NotImplementedException();
        }
    }
}
