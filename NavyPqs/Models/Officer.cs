using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NavyPqs.Models
{
    public class Officer
    {
        [JsonIgnore]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Rank { get; set; }

        public string ToJson() => JsonSerializer.Serialize(this);
    }
}
