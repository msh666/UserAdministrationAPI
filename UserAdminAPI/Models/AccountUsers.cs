using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserAdminAPI.Models
{
    public class AccountUsers
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
    }
}