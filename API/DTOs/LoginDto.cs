using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class LoginDto
    {
        public string EmailOrUsername { get; set; }

        public string Password { get; set; }
    }
}