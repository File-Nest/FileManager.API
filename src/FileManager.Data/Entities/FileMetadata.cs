using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace FileManager.Data.Entities
{
    public class FileMetadata : AuditableEntity
    {
        public Guid FileId { get; set; }
        public Guid OwnerUserId { get; set; }
        public string? FileName { get; set; }
        public string? ContentType { get; set; }
        public long? SizeBytes { get; set; }

        [JsonIgnore]
        public string? StorageKey { get; set; }

        [BsonRepresentation(BsonType.String)]
        public FileStatus Status { get; set; }
    }
}
