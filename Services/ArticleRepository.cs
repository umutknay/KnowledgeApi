using KnowledgeApi.Models;
using static KnowledgeApi.Services.MongoRepository;

namespace KnowledgeApi.Services
{
    public class ArticleRepository : BaseMongoRepository<Article>
    {
        public ArticleRepository(string mongoDBConnectionString, string dbName, string collectionName) : base(mongoDBConnectionString, dbName, collectionName)
        {
        }
    }
}
