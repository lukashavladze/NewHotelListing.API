using HotelListing.API.contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {

        }
    }
}
