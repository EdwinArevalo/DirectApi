using Application.Dtos.Request;
using Application.Services.Core.Interfaces;
using Common.HttpHelpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WICDirectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthGMController : ControllerBase
    {
        private readonly IAuthGMService _authGMService;

        public AuthGMController(IAuthGMService authGMService)
        {
            _authGMService = authGMService;
        }

        [HttpPost("GetSecurityKey")]
        public async Task<EResponseBase<SecurityKeyResponse>> GetSecurityKey([FromBody] SecurityKeyRequest request)
        {

            return await _authGMService.GetSecurityKey(request);

        }
    }
}
