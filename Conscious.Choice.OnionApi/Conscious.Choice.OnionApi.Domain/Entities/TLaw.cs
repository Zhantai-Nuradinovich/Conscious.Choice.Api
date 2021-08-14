using Conscious.Choice.OnionApi.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class TLaw : BaseEntity
    {
        public string LawName { get; set; }
        public string LawNumber { get; set; }
        public DateTime LawDate { get; set; }
        public LawCategory Category { get; set; }
        public string AddInfo { get; set; }
        public ICollection<TLawsAmendment> Amendments { get; set; }
    }
}
