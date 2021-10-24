using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class RLawsAmendment: BaseEntity //RLawsAmendment
    {
        public RLawsAmendment()
        {
            Votes = new HashSet<TVote>();
        }
        public int LawId { get; set; }
        public TLaw Law { get; set; }
        public DateTime AmendmentDate { get; set; }
        public string LinkToLaw { get; set; } //какой закон правили
        public string LinkToVotes { get; set; } //как голосовали
        public ICollection<TVote> Votes { get; set; }
    }
}
