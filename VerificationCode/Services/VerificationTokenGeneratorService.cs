using Microsoft.AspNetCore.DataProtection;
using Newtonsoft.Json;
using VerificationCode.Models;

namespace VerificationCode.Services
{
    public class VerificationTokenGeneratorService
    {
        private readonly IDataProtector _protecter;

        public VerificationTokenGeneratorService(IDataProtectionProvider provider)
        {
            _protecter = provider.CreateProtector("VerificationTokenGeneratorService");
        }

        public string Generate(Guid userId, VerificationType type, DateTimeOffset expirationTime)
        {
            var verificationToken = new VerificationToken
            {
                UserId = userId,
                Type = type,
                ExpireTime = DateTimeOffset.UtcNow.AddMinutes(5),
            };

            return _protecter.Protect(JsonConvert.SerializeObject(verificationToken));
        }
        
        public VerificationToken Decrypt(string verificationToken)
        {
            var unProtectedModel = _protecter.Unprotect(verificationToken);

            var model = JsonConvert.DeserializeObject<VerificationToken>(unProtectedModel) ??
                throw new InvalidOperationException("Verification token is invalid");

            return model;
        }
    }
}
