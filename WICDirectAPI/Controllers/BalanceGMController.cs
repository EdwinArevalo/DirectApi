using Application.Dtos.Request;
using Application.Services.Core.Implements;
using Application.Services.Core.Interfaces;
using Common.HttpHelpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WICDirectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceGMController : ControllerBase
    {
        private readonly IBalanceGMService _balanceGMService;

        public BalanceGMController(IBalanceGMService balanceGMService)
        {
            _balanceGMService = balanceGMService;
        }

        [HttpPost("GenerateBalance")]
        public async Task<ActionResult<EResponseBase<GenerateBalanceResponse>>> GenerateBalance(GenerateBalanceRequest request)
        {
            if ( String.IsNullOrEmpty(request.SecurityKeyGM))
            {
                return Unauthorized("Invalid Security Key");
            }

            return await _balanceGMService.GenerateBalance(request);

        }
    }
}
