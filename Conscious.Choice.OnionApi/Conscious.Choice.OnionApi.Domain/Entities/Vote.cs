using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class Vote : BaseEntity
    {
        public int LawId { get; set; }
        public Law Law { get; set; }
        public int DeputyId { get; set; }
        public Deputy Deputy { get; set; }
	public int DecisionId { get; set; }
        public Decision Decision { get; set; }
    }
}
