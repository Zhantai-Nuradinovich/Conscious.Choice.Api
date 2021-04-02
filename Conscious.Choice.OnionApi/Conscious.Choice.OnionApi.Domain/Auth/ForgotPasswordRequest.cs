using System.ComponentModel.DataAnnotations;

namespace Conscious.Choice.OnionApi.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
