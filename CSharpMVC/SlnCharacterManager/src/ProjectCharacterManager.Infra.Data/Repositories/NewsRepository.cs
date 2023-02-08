using ProjectCharacterManager.Domain.Entities;
using ProjectCharacterManager.Domain.IRepositories;
using ProjectCharacterManager.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCharacterManager.Infra.Data.Repositories
{
    public class NewsRepository : BaseRepository<News>, INewsRepository
    {
        private readonly SQLServerContext _context;

        public NewsRepository(SQLServerContext context) : base(context)
        {
            this._context = context;
        }
    }
}
