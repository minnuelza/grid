using Grid.Features.Common;
using Grid.Features.HRMS.DAL.Interfaces;
using Grid.Features.HRMS.Entities;

namespace Grid.Features.HRMS.DAL
{
    public class LocationRepository : GenericRepository<Location>, ILocationRepository
    {
        public LocationRepository(IDbContext context) : base(context)
        {

        }
    }
}