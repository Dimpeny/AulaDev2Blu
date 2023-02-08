using Microsoft.EntityFrameworkCore;
using ProjectCharacterManager.Domain.DTO;
using ProjectCharacterManager.Domain.IRepositories;
using ProjectCharacterManager.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCharacterManager.Application.Service.SQLServerServices
{
    public class WorldService : IWorldService
    {
        private readonly IWorldRepository _repository;
        public WorldService(IWorldRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }

        public List<WorldDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(c => new WorldDTO()
            {
                id = c.Id,
                name = c.Name,
                description = c.Description
            }).ToList();
        }

        public async Task<WorldDTO> FindById(int id)
        {
            var dto = new WorldDTO();
            return dto.MapToDTO( await _repository.FindById(id));
        }

        public Task<int> Save(WorldDTO entity)
        {
            if (entity.id > 0)
            {
                return _repository.Update(entity.MapToEntity());
            }else
            {
                return _repository.Save(entity.MapToEntity());
            }
        }


    }
}
