﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Request
{
    public class SecurityKeyRequest
    {
        public string User { get; set; }
        public string Password { get; set; }
    }
}
