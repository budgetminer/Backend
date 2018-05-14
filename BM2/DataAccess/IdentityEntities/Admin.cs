using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.DataAccess.IdentityEntities
{
    public class Admin
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public IdentityUser Identity { get; set; }

    }
}
