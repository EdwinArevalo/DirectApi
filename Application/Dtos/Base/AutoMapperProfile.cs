﻿using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Base
{
    internal class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
        
            CreateMap<Util, UtilDto>();
        }
    }
}
