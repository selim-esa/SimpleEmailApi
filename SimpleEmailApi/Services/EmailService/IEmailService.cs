using SimpleEmailApi.Models;

namespace SimpleEmailApi.Services.EmailService
{
	public interface IEmailService
	{
		void SendEmail(EmailDto request);
	}
}
