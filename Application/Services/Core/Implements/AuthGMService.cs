using Application.Dtos;
using Application.Dtos.Request;
using Application.Services.Core.Interfaces;
using AutoMapper;
using Common.HttpHelpers;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Core.Implements
{
    public class AuthGMService : IAuthGMService
    {
        private readonly UtilitariesResponse<SecurityKeyResponse> _utilitaries;
        private readonly IMapper _mapper;

        public AuthGMService(UtilitariesResponse<SecurityKeyResponse> utilitaries, IMapper mapper)
        {
            _utilitaries = utilitaries;
            _mapper = mapper;
        }

        public async Task<EResponseBase<SecurityKeyResponse>> GetSecurityKey(SecurityKeyRequest request)
        {
            var response = new EResponseBase<SecurityKeyResponse>();
            try
            {
                //Simula la petición al servicio de GM: GetSecurityKeyGM
                var securityKeyResponse = await GetSecurityKeyGM(request);


                if (securityKeyResponse != null)
                {
                    response = _utilitaries.setResponseBaseForObj(securityKeyResponse);
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

        public async Task<SecurityKeyResponse> GetSecurityKeyGM(SecurityKeyRequest request)
        {
            //if (request == null)
            //{
            //    return null;
            //}

            var response = new SecurityKeyResponse();
            await Task.Run(() => { response.SecurityKeyGM = $"GM-{Guid.NewGuid()}"; });
            return response;
        }
    }
}
