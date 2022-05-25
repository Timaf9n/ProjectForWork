using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProjectForWork.Models
{
    public class Model
    {
        public int id { get; set; }
        [Column("Model")]
        public string Name{ get; set; }
        [ForeignKey("Brand")]
        public int Brand_id { get; set; }

        //[ForeignKey(nameof(Brand_id))]
        [JsonIgnore]
        public Brand? Brand { get; set; }

        public List<Generation> GetGenerations { get; set; }

    }
}   
