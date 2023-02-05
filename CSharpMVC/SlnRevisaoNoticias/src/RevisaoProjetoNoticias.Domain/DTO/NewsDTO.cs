using RevisaoProjetoNoticias.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Category")]
        public int categoryId { get; set; }
        public DateTime? created { get; set; }
        public bool published { get; set; }

        public string? image { get; set; }

        public virtual CategoryDTO? category { get; set; }


        public News MapToEntity()
        {
            return new News()
            {
                Id = id,
                Title = title,
                Description = description,
                CategoryId = categoryId,
                Created = created,
                Published = published,
                Image = image
            };
        }

        public NewsDTO MapToDTO(News news)
        {
            return new NewsDTO()
            {
                id = news.Id,
                title = news.Title,
                description = news.Description,
                categoryId = news.CategoryId,
                created = news.Created,
                published = news.Published,
                image = news.Image
            };
        }
    }
}
