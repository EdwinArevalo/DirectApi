using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Request
{
    public class GenerateBalanceRequest
    {
        public string EbtCardNumber { get; set; }
        public string? SecurityKeyGM { get; set; }
        public string RequestId { get; set; }
    }
}
