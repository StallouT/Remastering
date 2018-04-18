using System;
using System.Collections.Generic;
using System.Text;

namespace Remastering.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Premium { get; set; }
        public int Premium_From { get; set; }
        public int Premium_Before { get; set; } 
    }
}
