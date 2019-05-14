using System.Collections.Generic;
using waldo.Domain.ApiModels;

namespace waldo.Domain
{
    public class CharactersDomain
    {
        public List<Character> GetCharacter()
        {
            return new List<Character>
            {
                new Character
                {
                    Name = "Waldo",
                    Description = "He is wearing a red and white striped shirt and hat."
                },
                new Character
                {
                    Name = "Carmen",
                    Description = "She likes to wear red."
                }
            };
        }

        public Character GetCharacter(string id)
        {
            var lower = id.ToLower();
            if (lower == "waldo")
            {
                return new Character
                {
                    Name = "Waldo",
                    Description = "When is he seen, he is wearing a red and white striped shirt and hat."
                };
            }

            if (lower == "carmen")
            {
                return new Character
                {
                    Name = "Carmen",
                    Description = "She is a super thief who likes to wear red."
                };

            }
            return null;
        }

        public Character UpdateCharacter(Character request)
        {
            return new Character
            {
                Name = request.Name,
                Description = request.Description
            };
        }

        public Character CreatePerson(Character request)
        {
            return new Character
            {
                Name = request.Name,
                Description = request.Description
            };
        }

        public string DeleteCharacter(string id)
        {
            var lower = id.ToLower();
            if (lower == "waldo" || lower == "carmen")
            {
                return "You cannot delete that person!";
            }

            return null;
        }
    }
}
