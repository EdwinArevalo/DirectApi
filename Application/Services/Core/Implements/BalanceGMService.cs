using Application.Dtos.Request;
using Application.Services.Core.Interfaces;
using AutoMapper;
using Common.HttpHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Core.Implements
{
    public class BalanceGMService : IBalanceGMService
    {
        private readonly UtilitariesResponse<GenerateBalanceResponse> _utilitaries;
        private readonly IMapper _mapper;

        public BalanceGMService(UtilitariesResponse<GenerateBalanceResponse> utilitaries, IMapper mapper)
        {
            _utilitaries = utilitaries;
            _mapper = mapper;
        }

        public async Task<EResponseBase<GenerateBalanceResponse>> GenerateBalance(GenerateBalanceRequest request)
        {
            var response = new EResponseBase<GenerateBalanceResponse>();
            try
            {
                //Simula la petición al servicio de GM: GenerateBalanceGM
                var balanceResponse = await GenerateBalanceGM(request);


                if (balanceResponse != null)
                {
                    response = _utilitaries.setResponseBaseForObj(balanceResponse);
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

        public async Task<GenerateBalanceResponse> GenerateBalanceGM(GenerateBalanceRequest request)
        {
            var response = new GenerateBalanceResponse();
            await Task.Run(() =>
            {
                response.CategoryNumber = 1001;
                response.CategoryName = "Alimentos";
                response.SubCategoryNumber = 2002;
                response.SubCategoryName = "Frutas y Verduras";
                response.ProductName = "Manzanas";
                response.BalanceAmount = 150.75m;
                response.UCM = "kg";
                response.FirstUserDate = DateTime.Now.AddMonths(-6);
                response.LastUseDate = DateTime.Now.AddDays(-7);
                response.LastTransactionDate = DateTime.Now.AddDays(-2);
                response.LastClaimedAmount = 20.50m;
                response.LastPaidAmount = 19.99m;
                response.LastStoreName = "Supermercado Central";
            });

            return response;
        }
    }
}
