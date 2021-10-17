using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class RDeputyPartyMovingsHistory : BaseEntity
    {
        public int IdDeputy { get; set; }
        public int IdParty { get; set; }
        public DateTime EntranceDate { get; set; }
        public bool IsCurrentParty { get; set; }

        [ForeignKey("IdDeputy")]
        public TDeputy Deputy { get; set; }
        [ForeignKey("IdParty")]
        public TParty Party { get; set; }
    }
}
