﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Util: AuditableBaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string Type { get; set; }
        public int? Order { get; set; }
    }
}
