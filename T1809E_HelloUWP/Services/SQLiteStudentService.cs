using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E_HelloUWP.Models;

namespace T1809E_HelloUWP.Services
{
    class SQLiteStudentService: IStudentService
    {
        public Task<Student> Create(Student student)
        {
            throw new NotImplementedException();
        }

        public Task<List<Student>> GetList()
        {
            throw new NotImplementedException();
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
