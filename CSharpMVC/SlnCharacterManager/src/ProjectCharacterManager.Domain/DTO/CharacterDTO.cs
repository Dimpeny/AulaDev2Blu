using ProjectCharacterManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCharacterManager.Domain.DTO
{
    public class CharacterDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int worldId { get; set; }
        public virtual WorldDTO? world { get; set; }

        public CharacterDTO MapToDTO(Character character) 
        {
            return new CharacterDTO
            {
                id = character.Id,
                name = character.Name, 
                description = character.Description, 
                worldId = character.WorldId
            };
        }

        public Character MapToEntity()
        {
            return new Character
            {
                Id = id,
                Name = name,
                Description = description,
                WorldId = worldId
            };
        }
    }
}
