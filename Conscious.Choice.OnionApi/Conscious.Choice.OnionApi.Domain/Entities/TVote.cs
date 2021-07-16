using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class TVote : BaseEntity
    {
        public int LawsAmendmentId { get; set; }
        public TLawsAmendment LawsAmendment { get; set; }
        public int DeputyId { get; set; }
        public TDeputy Deputy { get; set; }
        public Decision Decision { get; set; }
    }
}
