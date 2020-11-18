using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;
using NavyPqs.Services;

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

        public CwoPqs TwoBravo { get; set; } = CwoPqs.NewTwoBravo();

        public CwoPqs TwoAlpha { get; set; } = CwoPqs.NewTwoAlpha();

        public string ToJson() => JsonSerializer.Serialize(this);

        public bool Export(string path)
        {
            FileHelper.WriteOver(Path.Combine(path, LastName + FirstName + ".cw2bpqs"),
                ToJson());
            return true;
        }

        public static Officer CopyOfficer(Officer toCopyTo, Officer toCopyFrom)
        {
            toCopyTo.Id = toCopyFrom.Id;
            toCopyTo.FirstName = toCopyFrom.FirstName ?? toCopyTo.FirstName;
            toCopyTo.LastName = toCopyFrom.LastName ?? toCopyTo.LastName;
            toCopyTo.Rank = toCopyFrom.Rank ?? toCopyTo.Rank;
            toCopyTo.TwoAlpha = CwoPqs.CopyCwoPqs(toCopyTo.TwoAlpha, toCopyFrom.TwoAlpha);
            toCopyTo.TwoBravo = CwoPqs.CopyCwoPqs(toCopyTo.TwoBravo, toCopyFrom.TwoBravo);

            return toCopyTo;
        }
    }
}
