using KnowledgeApi.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeApi.Services
{
    public class ArticleCustomService
    {
        private readonly IMongoCollection<Article> _article;
        public ArticleCustomService(string mongoDBConnectionString, string dbName, string collectionName)
        {
            var client = new MongoClient(mongoDBConnectionString);
            var database = client.GetDatabase(dbName);

            _article = database.GetCollection<Article>(collectionName);
        }

        public virtual async Task<List<Article>> GetTopTen(int limit)
        {
            //return _article.AsQueryable().OrderByDescending(x => x.Id).Take(10).ToList();
            return await _article.Find(x => true).SortByDescending(x => x.Dates).Limit(limit).ToListAsync();
        }

    }
}
