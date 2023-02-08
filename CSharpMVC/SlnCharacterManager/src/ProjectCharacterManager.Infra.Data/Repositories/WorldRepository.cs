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
    public class WorldRepository : BaseRepository<World>, IWorldRepository
    {
        private readonly SQLServerContext _context;

        public WorldRepository(SQLServerContext context) : base(context)
        {
            this._context = context;
        }
    }
}
