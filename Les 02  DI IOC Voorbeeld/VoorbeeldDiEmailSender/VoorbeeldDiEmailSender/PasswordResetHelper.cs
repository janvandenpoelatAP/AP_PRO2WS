using System;

namespace VoorbeeldDiEmailSender
{
    public class PasswordResetHelper
    {
        private readonly IEmailSender _emailSender;

        public PasswordResetHelper(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void ResetPassword()
        {
            var newPassword = Guid.NewGuid().ToString();
            _emailSender.SendEmail(newPassword);
        }
    }
}
