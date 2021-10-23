using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class TParty : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public int? IdLeaderDeputy { get; set; }
        /// <summary>
        /// Possible parent party. Optional property
        /// </summary>
        public int? IdParentParty { get; set; }

        [ForeignKey("IdLeaderDeputy")]
        public TDeputy Leader { get; set; }
        [ForeignKey("IdParentParty")]
        public TParty ParentParty { get; set; }

        public ICollection<RDeputyPartyMovingsHistory> DeputyPartyMovingsHistory { get; set; }
        public ICollection<RPartyConvocation> PartyConvocation { get; set; }
    }
}
