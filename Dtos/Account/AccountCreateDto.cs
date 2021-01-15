using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dtos.Account
{
    public class AccountCreateDto
    {

        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Language { get; set; }

    }
}