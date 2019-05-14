using System;
using System.Text;
using waldo.Domain.ApiModels;

namespace waldo.Domain
{
    public class SearchDomain
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
                    Message = "You found Daenerys! Run away!"
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
