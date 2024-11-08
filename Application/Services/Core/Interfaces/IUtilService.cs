using Application.Dtos;
using Common.HttpHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Core.Interfaces
{
    public interface IUtilService
    {
        Task<EResponseBase<UtilDto>> GetUtils();
        
    }
}
