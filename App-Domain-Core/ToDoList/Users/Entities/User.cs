using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Domain_Core.ToDoList.Users.Entities
{
    public class User : IdentityUser<int>
    {
        public string NationalCode { get; set; }
    }
}
