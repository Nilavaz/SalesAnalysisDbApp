using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SalesAnalysisDbApp.Models
{
  public class SalesRecord
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id{ get; set; }

    [BsonElement("productName")]
    public string ProductName { get; set; } = string.Empty;

    [BsonElement("quantity")]
    public int Quantity { get; set; }

    [BsonElement("price")]
    public decimal Price { get; set; }

    [BsonElement("customer")]
    public string Customer { get; set; }

    [BsonElement("saleDate")]
    public DateTime SaleDate { get; set; }
  }
}
