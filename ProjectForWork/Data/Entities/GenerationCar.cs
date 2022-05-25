using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProjectForWork.Models
{
    public class Generation
    {
        public int id { get; set; }
        [Column("Generation")]
        public string Name { get; set; }
        [ForeignKey("Model")]
        public int? Model_id { get; set; }

        [JsonIgnore]
        public Model? Model { get; set; }

    }
}
