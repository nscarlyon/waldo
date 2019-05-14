using System;
using System.Text;

namespace waldo.Domain
{
    public class Search
    {
        public SearchResponse ForCharacterByLocation(string characterName, string locationName)
        {
            var lowerLocationName = locationName.ToLower();
            var lowerCharacterName = characterName.ToLower();

            if (lowerLocationName == "san diego" && lowerCharacterName == "carmen")
            {
                return new SearchResponse
                {
                    Message = "You found Carmen Sandiego!"
                };
            }

            if (lowerLocationName == "atlanta" && lowerCharacterName == "waldo")
            {
                return new SearchResponse
                {
                    Message = "You found Waldo!"
                };
            }

            if (lowerLocationName == "kings landing" && lowerCharacterName == "daenerys")
            {
                return new SearchResponse
                {
                    Message = "You found Waldo!"
                };
            }

            if (lowerCharacterName == "waldo" || lowerCharacterName == "carmen")
            {
                return new SearchResponse
                {
                    Message = $"Sorry, {characterName} is not here."
                };
            }
            return null;
        }
    }
}
