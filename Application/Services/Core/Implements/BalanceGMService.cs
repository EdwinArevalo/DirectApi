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
                var balanceListResponse = await GenerateBalanceGM(request);


                if (balanceListResponse != null && balanceListResponse.Count > 0)
                {
                    response = _utilitaries.setResponseBaseForList(balanceListResponse);
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

        public async Task<List<GenerateBalanceResponse>> GenerateBalanceGM(GenerateBalanceRequest request)
        {
            var response = new List<GenerateBalanceResponse>();
            int itemCount = new Random().Next(1, 4);

            await Task.Run(() =>
            {
                for (int i = 0; i < itemCount; i++)
                {
                    response.Add(new GenerateBalanceResponse
                    {
                        CategoryNumber = 1000 + i,
                        CategoryName = i % 2 == 0 ? "Alimentos" : "Higiene",
                        SubCategoryNumber = 2000 + i,
                        SubCategoryName = i % 2 == 0 ? "Frutas y Verduras" : "Limpieza Personal",
                        ProductName = i % 2 == 0 ? "Manzanas" : "Jabón",
                        BalanceAmount = (new Random().Next(50, 200)),
                        UCM = i % 2 == 0 ? "kg" : "unidades",
                        FirstUserDate = DateTime.Now.AddMonths(-new Random().Next(1, 12)),
                        LastUseDate = DateTime.Now.AddDays(-new Random().Next(1, 30)),
                        LastTransactionDate = DateTime.Now.AddDays(-new Random().Next(1, 10)),
                        LastClaimedAmount = (new Random().Next(10, 30)),
                        LastPaidAmount = (new Random().Next(10, 30)),
                        LastStoreName = i % 2 == 0 ? "Supermercado Central" : "Mercado Popular"
                    });
                }
            });

            return response;
        }
    }
}
