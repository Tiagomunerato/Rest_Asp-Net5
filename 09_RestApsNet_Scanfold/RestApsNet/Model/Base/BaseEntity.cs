﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestApsNet.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id {get;set;}

    }
}
