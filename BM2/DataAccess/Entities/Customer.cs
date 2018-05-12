using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.DataAccess.Entities
{
    public class Customer : EntityBase
    {
        [Required] public string Name { get; set; }
        //List<Team> Teams { get; set; }
    }
}

