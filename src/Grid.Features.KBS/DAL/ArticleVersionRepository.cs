using Grid.Features.Common;
using Grid.Features.KBS.DAL.Interfaces;
using Grid.Features.KBS.Entities;

namespace Grid.Features.KBS.DAL
{
    public class ArticleVersionRepository : GenericRepository<ArticleVersion>, IArticleVersionRepository
    {
        public ArticleVersionRepository(IDbContext context) : base(context)
        {

        }
    }
}