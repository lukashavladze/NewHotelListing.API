using HotelListing.API.Data;

namespace HotelListing.API.contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
