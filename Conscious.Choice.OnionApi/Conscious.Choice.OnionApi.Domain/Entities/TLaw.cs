using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class TLaw : BaseEntity
    {
        public string LawName { get; set; }
        public int LawNumber { get; set; }
        public LawCategory Category { get; set; }
        public string AddInfo { get; set; }
        public ICollection<TLawsAmendment> Amendments { get; set; }
    }
}
