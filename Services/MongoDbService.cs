using MongoDB.Driver;

public class MongoDbService
{
  private readonly IMongoCollection<SalesRecord> _collection;

  public MongoDbService(IConfiguration config)
  {
    var client = new MongoClient(config["MongoDb: ConnectionString"]);
    var database = client.GetDatabase(config["MongoDb: DatabaseName"]);
    _collection = database.GetCollection<SalesRecord>(config["MongoDb: CollectionName"]);
  }
  
}
