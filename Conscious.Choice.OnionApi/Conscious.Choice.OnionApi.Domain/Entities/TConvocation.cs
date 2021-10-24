using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class TConvocation : BaseEntity
    {
        public TConvocation()
        {
            RPartyConvocation = new HashSet<RPartyConvocation>();
        }
        public int ConvocationNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<RPartyConvocation> RPartyConvocation { get; set; }
    }
}
