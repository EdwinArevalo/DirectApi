using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Repositories.Base;
using Persistence.Repositories.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Core.Implements
{
    public class UtilRepository : BaseRepository<Util>, IUtilRepository
    {
        public UtilRepository(AppDbContext context) : base(context)
        {

        }
    }
}
