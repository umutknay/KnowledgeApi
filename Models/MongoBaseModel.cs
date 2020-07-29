using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeApi.Models
{
    public class MongoBaseModel
    {
        public ObjectId Id { get; set; }
    }
}
