using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NavyPqs.Models
{
    public class Section
    {
        public string Name { get; set; }

        public string Number { get; set; }

        public string[] LineItem { get; set; }

        public bool[] Signed { get; set; }

        //public List<Signature> Signatures { get; set; }

        public static Section CopySection(Section toCopyTo, Section toCopyFrom)
        {
            if (toCopyFrom == null)
            {
                return toCopyTo;
            }

            for(int i = 0; i < toCopyTo.Signed.Length; i++)
            {
                toCopyTo.Signed[i] = toCopyFrom.Signed[i];
            }
            return toCopyTo;
        }
    }
}
