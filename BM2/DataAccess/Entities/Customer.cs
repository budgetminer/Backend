using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.DataAccess.Entities
{
    /*
    CREATE TABLE cu (
        id     NUMBER NOT NULL,
        name   VARCHAR2(30) NOT NULL
    );
    */
    public class Customer : EntityBase
    {
        [Required] public string Name { get; set; }
        //List<Team> Teams { get; set; }
    }
    /* methodes:
    *  Standard post(cu)
    *  Standard delete(id)
    *  Standard update(cu, id)
    *  Standard get() - allemaal
    *  Standard get(id) - specified
    */
}

