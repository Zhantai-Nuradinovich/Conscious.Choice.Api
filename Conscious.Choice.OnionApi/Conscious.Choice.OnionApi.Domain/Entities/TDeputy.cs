using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class TDeputy : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TVote> Votes { get; set; }
    }
}
