using Application.Dtos;
using Application.Services.Core.Interfaces;
using AutoMapper;
using Common.HttpHelpers;
using Domain.Entities;
using Persistence.Repositories.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Core.Implements
{
    public class UtilService : IUtilService
    {
        private readonly IUtilRepository _utilRepository;
        private readonly UtilitariesResponse<UtilDto> _utilitaries;
        private readonly IMapper _mapper;

        public UtilService(IUtilRepository utilRepository, UtilitariesResponse<UtilDto> utilitaries, IMapper mapper)
        {
            _utilRepository = utilRepository;
            _utilitaries = utilitaries;
            _mapper = mapper;
        }

        public async Task<EResponseBase<UtilDto>> GetUtils()
        {
            EResponseBase<UtilDto> response;
            try
            {
                var respondent = await _utilRepository.GetAll();
                if (respondent != null)
                {
                    respondent = respondent.OrderBy(u => u.Order).ToList();
                    var utils = _mapper.Map<List<Util>, List<UtilDto>>(respondent);
                    response = _utilitaries.setResponseBaseForList(utils);
                }
                else
                {
                    response = _utilitaries.setResponseBaseForNoDataFound();
                }
            }
            catch (Exception e)
            {
                response = _utilitaries.setResponseBaseForException(e);
            }

            return response;
        }
 
    }
}
