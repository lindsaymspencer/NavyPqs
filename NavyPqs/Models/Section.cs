using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NavyPqs.Models
{
    public class Section
    {
        public string Name { get; set; }
        [Key]
        public string Number { get; set; }

        public List<Signature> Signatures { get; set; }
    }
}
