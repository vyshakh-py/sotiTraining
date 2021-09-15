using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment1
{
    
    class User
    {
        string Title;
        string FirstName { get; set; }
        string Email { get; set; }
        string DOB { get; set; }

        public User(string title, string name, string email, string dob)
        {
            this.FirstName = name;
            this.Title = title;
            this.Email = email;
            this.DOB = dob;
            
        }
        public void changePW()
        {

        }
       
    }

    enum Role
    {
        Physician, Nurse, Admin
    }

    class Patient : User
    {
        public double ContactNumber { get; set; }
        private string password { get; set; }

        
    }
}
