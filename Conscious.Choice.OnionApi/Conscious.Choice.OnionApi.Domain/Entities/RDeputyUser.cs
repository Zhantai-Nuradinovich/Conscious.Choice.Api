using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    /// <summary>
    /// Model for saving favorite candidates
    /// </summary>
    public class RDeputyUser : BaseEntity
    {
        public int IdDeputy { get; set; }
        public string IdUser { get; set; }
        public bool IsFavorite { get; set; }


        [ForeignKey("IdDeputy")]
        public TDeputy Deputy { get; set; }

        [ForeignKey("IdUser")]
        public Auth.ApplicationUser User { get; set; }
    }
}
