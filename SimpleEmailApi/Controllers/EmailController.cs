using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using SimpleEmailApi.Models;
using SimpleEmailApi.Services.EmailService;

namespace SimpleEmailApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmailController : ControllerBase
	{
		private readonly IEmailService _emailService;
		public EmailController(IEmailService emailService)
		{
			_emailService = emailService;
		}


		[HttpPost]
		public IActionResult SendEmail(EmailDto request)
		{
			_emailService.SendEmail(request);
			return Ok();
		}
	}
}
