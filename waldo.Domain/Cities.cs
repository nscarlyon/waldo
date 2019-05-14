using System.Collections.Generic;

namespace waldo.Domain
{
    public class Cities
    {
        public CitiesResponse GetCities()
        {
            var cityResponse = new CitiesResponse
            {
                Cities = new List<City>
                {
                    new City
                    {
                        name = "Atlanta",
                        state = "Georgia"
                    },
                    new City
                    {
                        name = "Duluth",
                        state = "Georgia",
                    },
                    new City
                    {
                        name = "Phoenix",
                        state = "Arizona"
                    },
                    new City
                    {
                        name = "Scottsdale",
                        state = "Arizona"
                    },
                    new City
                    {
                        name = "San Diego",
                        state = "California"
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
                    name = "Atlanta",
                    state = "Georgia"
                };
            }
            if (lower == "cumming")
            {
                return new City
                {
                    name = "Cumming",
                    state = "Georgia"
                };
            }

            return null;
        }

        public City UpdateCity(City request)
        {
            return new City
            {
                name = request.name,
                state = request.state
            };
        }

        public City CreateCity(City request)
        {
            return new City
            {
                name = request.name,
                state = request.state
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
