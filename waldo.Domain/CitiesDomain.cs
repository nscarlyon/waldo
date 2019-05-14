using System.Collections.Generic;
using waldo.Domain.ApiModels;

namespace waldo.Domain
{
    public class CitiesDomain
    {
        public CitiesResponse GetCities()
        {
            var cityResponse = new CitiesResponse
            {
                Cities = new List<City>
                {
                    new City
                    {
                        Name = "Atlanta",
                        State = "Georgia"
                    },
                    new City
                    {
                        Name = "Duluth",
                        State = "Georgia",
                    },
                    new City
                    {
                        Name = "Phoenix",
                        State = "Arizona"
                    },
                    new City
                    {
                        Name = "Scottsdale",
                        State = "Arizona"
                    },
                    new City
                    {
                        Name = "San Diego",
                        State = "California"
                    }
                }
            };
            return cityResponse;
        }

        public City GetCity(string city)
        {
            var lower = city.ToLower();

            if (lower == "atlanta")
            {
                return new City
                {
                    Name = "Atlanta",
                    State = "Georgia"
                };
            }
            if (lower == "cumming")
            {
                return new City
                {
                    Name = "Cumming",
                    State = "Georgia"
                };
            }

            return null;
        }

        public City UpdateCity(City request)
        {
            return new City
            {
                Name = request.Name,
                State = request.State
            };
        }

        public City CreateCity(City request)
        {
            return new City
            {
                Name = request.Name,
                State = request.State
            };
        }

        public FindWaldoResponse FindWaldo(string cityName)
        {
            return cityName.ToLower() == "atlanta"
                ? new FindWaldoResponse
                {
                    Message = "You found him!"
                }
                : new FindWaldoResponse
                {
                    Message = "Sorry, Waldo is not here."
                };
        }

        public FindWaldoResponse WhereIsWaldo()
        {
            return new FindWaldoResponse
            {
                Message = "He is in Atlanta"
            };
        }
    }
}
