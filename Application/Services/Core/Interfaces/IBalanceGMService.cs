using Application.Dtos.Request;
using Common.HttpHelpers;

namespace Application.Services.Core.Interfaces
{
    public interface IBalanceGMService
    {
        Task<EResponseBase<GenerateBalanceResponse>> GenerateBalance(GenerateBalanceRequest request);
    }
}