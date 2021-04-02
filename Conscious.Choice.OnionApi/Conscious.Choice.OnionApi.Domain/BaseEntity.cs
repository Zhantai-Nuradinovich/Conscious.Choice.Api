using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
