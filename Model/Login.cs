using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Login
    {
        string _user_Id;
        string _password;
        string _security_Question;
        string _answer;
        string _role;

        public string User_Id { get => _user_Id; set => _user_Id = value; }
        public string Password { get => _password; set => _password = value; }
        public string Security_Question { get => _security_Question; set => _security_Question = value; }
        public string Answer { get => _answer; set => _answer = value; }
        public string Role { get => _role; set => _role = value; }
    }
}