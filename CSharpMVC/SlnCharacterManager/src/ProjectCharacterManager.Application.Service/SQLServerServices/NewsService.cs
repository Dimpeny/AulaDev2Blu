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
    public class NewsService : INewsService
    {
        private readonly INewsRepository _repository;

        public NewsService(INewsRepository repository)
        {
             _repository = repository;
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
             return await _repository.Delete(entity);
            
        }

        public List<NewsDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(n => new NewsDTO()
                {
                    id = n.Id,
                    title = n.Title,
                    description = n.Description,
                    categoryId = n.CategoryId,
                    created = n.Created,
                    published = n.Published
                }).ToList();
        }

        public async Task<NewsDTO> FindById(int id)
        {
            var dto = new NewsDTO();
            return dto.MapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(NewsDTO entity)
        {
            if (entity.id > 0)
            {
                if(entity.created == null)
                {
                    entity.created = DateTime.Now;
                }
                return _repository.Update(entity.MapToEntity());
            }
            else
            {
                entity.created = DateTime.Now;
                return _repository.Save(entity.MapToEntity());
            }
        }
    }
}
