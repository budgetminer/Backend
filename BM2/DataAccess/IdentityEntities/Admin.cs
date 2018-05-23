using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.DataAccess.IdentityEntities
{
    public class Admin
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public IdentityUser Identity { get; set; }

    }
}
