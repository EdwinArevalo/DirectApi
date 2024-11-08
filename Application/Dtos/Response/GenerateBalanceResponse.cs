using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Request
{
    public class GenerateBalanceResponse
    {
        public int CategoryNumber { get; set; }
        public string CategoryName { get; set; }
        public int SubCategoryNumber { get; set; }
        public string SubCategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal BalanceAmount { get; set; }
        public string UCM { get; set; }
        public DateTime FirstUserDate { get; set; }
        public DateTime LastUseDate { get; set; }
        public DateTime LastTransactionDate { get; set; }
        public decimal LastClaimedAmount { get; set; }
        public decimal LastPaidAmount { get; set; }
        public string LastStoreName { get; set; }
    }
}
