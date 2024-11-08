using Application.Dtos;
using Application.Services.Core.Interfaces;
using Common.HttpHelpers;
using Microsoft.AspNetCore.Mvc;

namespace WICDirectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilController : ControllerBase
    {
        private readonly IUtilService _utilService;

        public UtilController(IUtilService utilService)
        {
            _utilService = utilService;
        }

        [HttpGet]
        public async Task<EResponseBase<UtilDto>> Get()
        {
            return await _utilService.GetUtils();
        }
    }
}
