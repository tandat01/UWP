using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1809E_HelloUWP.Models
{
    public class Student
    {
        public long id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string avatar { get; set; }
        public int gender { get; set; }
        public string email { get; set; }
        public string birthday { get; set; }

        public Dictionary<string, string> CheckValidate()
        {
            var errors = new Dictionary<string, string>();
            if (string.IsNullOrEmpty(this.firstName))
            {
                errors.Add("firstName", "First name is required!");
            }
            return errors;
        }
    }
}
