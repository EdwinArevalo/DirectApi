using Application.Dtos.Request;
using Common.HttpHelpers;

namespace Application.Services.Core.Interfaces
{
    public interface IAuthGMService
    {
        Task<EResponseBase<SecurityKeyResponse>> GetSecurityKey(SecurityKeyRequest request);
    }
}