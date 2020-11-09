using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.ViewModels
{
    public class RegisterModel
    {
        public string Forenames { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
