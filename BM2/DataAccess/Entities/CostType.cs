﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.DataAccess.Entities
{
    /*
    CREATE TABLE coty (
        id       NUMBER NOT NULL,
        abbrev   VARCHAR2(10) NOT NULL,
        descr    VARCHAR2(250) NOT NULL
    */
    public class CostType : EntityBase
    {
        // id autogenerated
        [Required] public string Abbreviation { get; set; }
        [Required] public string Description { get; set; }
    }

    /* methodes:
     *  Standard post(cu)
     *  Standard delete(id)
     *  Standard update(cu, id)
     *  Standard get() - allemaal
     *  Standard get(id) - specified
    */
}
