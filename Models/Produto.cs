using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApplication1.Models
{
    public class Produto
    {
        [BsonId] // dita que é a chave primaria
        [BsonRepresentation(BsonType.ObjectId)] // faz com que o banco faz gerar a chave
        public string? Id { get; set; }
        [BsonElement("Nome")] // Dita o nome da coluna no banco
        public string Nome { get; set; } = null;
    }
}
