using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NavyPqs.Models
{
    public class Signature
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        public string SomeKey { get; set; }

        public bool SignedOff { get; set; }
    }
}
