using ProjectCharacterManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCharacterManager.Domain.DTO
{
    public class WorldDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public virtual ICollection<Character>? charactersList { get; set; }

        public WorldDTO MapToDTO(World world)
        {
            return new WorldDTO
            {
                id = world.Id,
                name = world.Name,
                description = world.Description
            };
        }

        public World MapToEntity()
        {
            return new World
            {
                Id = id,
                Name = name,
                Description = description
            };
        }
    }
}
