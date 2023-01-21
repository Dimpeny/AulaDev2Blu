using RevisaoProjetoNoticias.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProjetoNoticias.Domain.DTO
{
    public class NewsDTO
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int categoryId { get; set; }
        public DateTime? created { get; set; }
        public bool published { get; set; }

        public virtual CategoryDTO? category { get; set; }

        public News mapToEntity()
        {
            return new News()
            {
                Id = id,
                Title = title,
                Description = description,
                CategoryId = categoryId,
                Created = created,
                Published = published
            };
        }

        public NewsDTO mapToDTO(News news)
        {
            return new NewsDTO()
            {
                id = news.Id,
                title = news.Title,
                description = news.Description,
                categoryId = news.CategoryId,
                created = news.Created,
                published = news.Published,
                category = new CategoryDTO()
                {
                    id = news.Category.Id,
                    name = news.Category.Name

                }
            };
        }
    }
}
