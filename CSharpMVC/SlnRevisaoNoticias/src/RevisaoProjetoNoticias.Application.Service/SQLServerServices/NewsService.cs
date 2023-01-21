using RevisaoProjetoNoticias.Domain.DTO;
using RevisaoProjetoNoticias.Domain.IRepositories;
using RevisaoProjetoNoticias.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProjetoNoticias.Application.Service.SQLServerServices
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _repository;

        public NewsService(INewsRepository repository)
        {
             _repository = repository;
        }
        public Task<int> Delete(NewsDTO entity)
        {
            throw new NotImplementedException();
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

        public Task<NewsDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(NewsDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
