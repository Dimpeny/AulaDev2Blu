using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCharacterManager.Domain.Entities
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime? Created { get; set; }
        public bool Published { get; set; }

        public virtual Category? Category { get; set; }
        public string Image { get; internal set; }
    }
}
