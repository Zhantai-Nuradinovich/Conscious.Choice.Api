using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    /// <summary>
    /// Model for candidates
    /// </summary>
    public class TDeputy : BaseEntity
    {
        public TDeputy()
        {
            Votes = new HashSet<TVote>();
            DeputyUser = new HashSet<RDeputyUser>();
            DeputyPartyMovingsHistory = new HashSet<RDeputyPartyMovingsHistory>();
        }
        public string Name { get; set; }
        /// <summary>
        /// If not, it's just a Candidate
        /// </summary>
        public bool IsRealDeputy { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Information { get; set; }
        public ICollection<TVote> Votes { get; set; }
        public ICollection<RDeputyUser> DeputyUser { get; set; }
        public ICollection<RDeputyPartyMovingsHistory> DeputyPartyMovingsHistory { get; set; }
    }
}
