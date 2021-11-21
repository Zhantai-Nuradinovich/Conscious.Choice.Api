using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class RPartyConvocation : BaseEntity
    {
        public int IdParty { get; set; }
        public int IdConvocation { get; set; }
        public bool HasWon { get; set; }

        [ForeignKey("IdParty")]
        public TParty Party { get; set; }
        [ForeignKey("IdConvocation")]
        public TConvocation Convocation { get; set; }
    }
}
