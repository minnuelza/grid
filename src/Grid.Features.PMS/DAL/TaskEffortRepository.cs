using Grid.Features.Common;
using Grid.Features.PMS.DAL.Interfaces;
using Grid.Features.PMS.Entities;

namespace Grid.Features.PMS.DAL
{
    public class TaskEffortRepository : GenericRepository<TaskEffort>, ITaskEffortRepository
    {
        public TaskEffortRepository(IDbContext context) : base(context)
        {

        }
    }
}