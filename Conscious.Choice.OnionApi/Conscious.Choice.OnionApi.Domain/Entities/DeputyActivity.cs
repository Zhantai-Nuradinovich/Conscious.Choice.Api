using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class DeputyActivity
    {
        public string Name { get; set; }
        public List<Vote> Votes { get; set; }
    }
}
