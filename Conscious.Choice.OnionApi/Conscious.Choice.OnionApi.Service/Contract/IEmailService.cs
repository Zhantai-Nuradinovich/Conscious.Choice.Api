using Conscious.Choice.OnionApi.Domain.Settings;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
