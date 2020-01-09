using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E_HelloUWP.Models;

namespace T1809E_HelloUWP.Services
{
    interface IStudentService
    {
        Task<Student> Create(Student student);
        Task<List<Student>> GetList();
        Task<Student> GetDetail(string rollNumber);
        Task<Student> Update(Student student);
        Task<bool> Delete(string rollNumber);
    }
}
