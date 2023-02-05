using RevisaoProjetoNoticias.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProjetoNoticias.Domain.DTO
{
    public class CategoryDTO
    {

        public int id { get; set; }
        public string name { get; set; }

        public virtual ICollection<NewsDTO>? newsList { get; set; }

        public CategoryDTO MapToDTO(Category category)
        {
            return new CategoryDTO
            {
                id = category.Id,
                name = category.Name/*,
                newsList = category.NewsList.Select(c => new NewsDTO()
                {

                }).ToList()
                */
            };
        }

        public Category MapToEntity()
        {
            return new Category()
            {
                Id = id,
                Name = name
            };
        }
    }
}
