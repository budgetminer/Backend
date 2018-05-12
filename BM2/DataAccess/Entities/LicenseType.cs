﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BM2.DataAccess.Entities
{
            /*
        CREATE TABLE lity (
            id       NUMBER NOT NULL,
            abbrev   VARCHAR2(10) NOT NULL,
            type     VARCHAR2(30) NOT NULL
            );
        */
    public class LicenseType : EntityBase {

        // id autogenerated
        public string abbrev { get; set; }
        public string type { get; set; }
    }

    /* methodes:
     *  Standard post(cu)
     *  Standard delete(id)
     *  Standard update(cu, id)
     *  Standard get() - allemaal
     *  Standard get(id) - specified
    */
}
